using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.Persistence;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.Repository
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {

        public NotificationRepository(ChildNotificationDBContext childNotificationDBContext) : base(childNotificationDBContext)
        {

        }

        public async Task<List<NotificationCase>> GetNotificationCasesBySupervisor(string supervisorName)
        {
            return await _childNotificationDBContext.NotificationCases.FromSqlRaw("Get_NotificationCasesBySupervisor @SupervisorName",
                                                                        new SqlParameter("@SupervisorName", supervisorName)).ToListAsync();
        }

        public async Task<Notification> AddNotification(Notification notification)
        {
            await _childNotificationDBContext.Notifications.AddAsync(notification);
            await _childNotificationDBContext.SaveChangesAsync();
            return notification;

        }

        public async Task<Notification> UpdateNotification(Notification notification)
        {
            _childNotificationDBContext.Notifications.Update(notification);
            await _childNotificationDBContext.SaveChangesAsync();
            return notification;
        }

        public async Task<Notification> GetNotificationById(int notificationId)
        {
            return await _childNotificationDBContext.Notifications.SingleOrDefaultAsync(n => n.NotificacationId == notificationId);
        }
    }
}
