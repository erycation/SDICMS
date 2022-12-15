using AutoMapper;
using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Repository.Interface;
using MSChildNotification.Shared.Helpers;

namespace MSChildNotification.NotificationDomain.Service
{
    public class NotificationService : INotificationService
    {

        private readonly IMapper _mapper;
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(IMapper mapper,
                                  INotificationRepository notificationRepository)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
        }

        public async Task<List<NotificationCaseDto>> GetNotificationCasesBySupervisor(string supervisorName)
        {
            var responseNotificationCases = await _notificationRepository.GetNotificationCasesBySupervisor(supervisorName);
            return _mapper.Map<List<NotificationCaseDto>>(responseNotificationCases);
        }
      
        public async Task<NotificationDto> UpdateResponseStatusAfterAssignCaseToPoc(int notificationId)
        {
            var responseNotification = await _notificationRepository.GetNotificationById(notificationId);
            if (responseNotification == null)
                throw new AppException($"Notification not found.");

            responseNotification.RespondStatus = 2;
            //responseNotification.Timestamp = responseNotification.Timestamp;
            var responseUpdatedNotification = await _notificationRepository.UpdateNotification(responseNotification);
            return _mapper.Map<NotificationDto>(responseUpdatedNotification);
        }
    }
}
