using AutoMapper;
using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Model.Request;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Repository.Interface;
using MSChildNotification.Shared.Helpers;

namespace MSChildNotification.NotificationDomain.Service
{
    public class CaseInformationService : ICaseInformationService
    {

        private readonly IMapper _mapper;
        private readonly ICaseInformationRepository _caseInformationRepository;
        private readonly INotificationService _notificationService;

        public CaseInformationService(IMapper mapper,
                                  ICaseInformationRepository caseInformationRepository,
                                  INotificationService notificationService)
        {
            _mapper = mapper;
            _caseInformationRepository = caseInformationRepository;
            _notificationService = notificationService;
        }

        public async Task<CaseInformationDto> AssignCaseToProbationOfficer(RequestAssignCase requestAssignCase)
        {
            await _notificationService.UpdateResponseStatusAfterAssignCaseToPoc(requestAssignCase.NotificationId);
            var responseCaseInformation = await _caseInformationRepository.GetCaseInformationById(requestAssignCase.CaseInformationId);
            if(responseCaseInformation == null)
                throw new AppException($"Case information not found.");

            if (responseCaseInformation.ProbationOfficerInformationID != null)
            {
                //send email message for cancellation, will re-assign to new POC

            }

            responseCaseInformation.ProbationOfficerInformationID = requestAssignCase.ProbationOfficerId;
            responseCaseInformation.ProbationOfficerAllocatedDate = DateTime.Now;
            responseCaseInformation.ProbationOfficerContactTypeId = requestAssignCase.ContactTypeId.ToString();

            var responseUpdatedCaseInformation = await _caseInformationRepository.UpdateCaseInformation(responseCaseInformation);

            //send email message to assign case POC

            return _mapper.Map<CaseInformationDto>(responseUpdatedCaseInformation);
        }
    }
}
