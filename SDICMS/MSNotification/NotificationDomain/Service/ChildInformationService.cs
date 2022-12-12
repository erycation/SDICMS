using AutoMapper;
using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.NotificationDomain.Service
{
    public class ChildInformationService : IChildInformationService
    {

        private readonly IMapper _mapper;
        private readonly IChildInformationRepository _childInformationRepository;

        public ChildInformationService(IMapper mapper,
                                  IChildInformationRepository childInformationRepository)
        {
            _mapper = mapper;
            _childInformationRepository = childInformationRepository;
        }

        public async Task<ChildInformationDto> GetChildInformationById(int childInformationId)
        {
            var responseChildInformation = await _childInformationRepository.GetChildInformationById(childInformationId);
            return responseChildInformation == null ? new ChildInformationDto() : _mapper.Map<ChildInformationDto>(responseChildInformation);
        }
    }
}
