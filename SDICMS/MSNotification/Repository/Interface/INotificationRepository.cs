using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Repository.Interface
{
    public interface INotificationRepository
    {
        Task<List<NotificationCase>> GetNotificationCasesBySupervisor(string supervisorName);
    }
}
