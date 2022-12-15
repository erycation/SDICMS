using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Repository.Interface
{
    public interface INotificationRepository
    {
        Task<List<NotificationCase>> GetNotificationCasesBySupervisor(string supervisorName);
        Task<Notification> AddNotification(Notification notification);
        Task<Notification> UpdateNotification(Notification notification);
        Task<Notification> GetNotificationById(int notificationId);
    }
}
