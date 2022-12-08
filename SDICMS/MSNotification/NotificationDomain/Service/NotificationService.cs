using AutoMapper;
using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Repository.Interface;

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
    }
}
