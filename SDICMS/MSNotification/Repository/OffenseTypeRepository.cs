using Microsoft.EntityFrameworkCore;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.Persistence;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.Repository
{
    public class OffenseTypeRepository : Repository<OffenseType>, IOffenseTypeRepository
    {

        public OffenseTypeRepository(ChildNotificationDBContext childNotificationDBContext) : base(childNotificationDBContext)
        {

        }

        public async Task<OffenseType> GetOffenseTypeByCode(string offenseCode)
        {
            return await _childNotificationDBContext.OffenseTypes.FirstOrDefaultAsync(o => o.OffenseCode == offenseCode);
        }
    }
}
