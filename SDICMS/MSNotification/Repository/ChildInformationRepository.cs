using Microsoft.EntityFrameworkCore;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.Persistence;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.Repository
{
    public class ChildInformationRepository : Repository<ChildInformation>, IChildInformationRepository
    {

        public ChildInformationRepository(ChildNotificationDBContext childNotificationDBContext) : base(childNotificationDBContext)
        {

        }

        public async Task<ChildInformation> GetChildInformationById(int childInformationId)
        {
            return await _childNotificationDBContext.ChildInformations.SingleOrDefaultAsync(c => c.ChildInformationId == childInformationId);
        }
    }
}
