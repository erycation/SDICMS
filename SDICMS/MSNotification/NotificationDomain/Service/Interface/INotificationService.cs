using MSChildNotification.NotificationDomain.Model.Dtos;

namespace MSChildNotification.NotificationDomain.Service.Interface
{
    public interface INotificationService
    {
        Task<List<NotificationCaseDto>> GetNotificationCasesBySupervisor(string supervisorName);
        Task<NotificationDto> UpdateResponseStatusAfterAssignCaseToPoc(int notificationId);
    }
}
