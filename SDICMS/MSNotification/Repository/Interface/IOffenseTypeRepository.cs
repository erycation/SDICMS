using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Repository.Interface
{
    public interface IOffenseTypeRepository
    {
        Task<OffenseType> GetOffenseTypeByCode(string offenseCode);
    }
}
