using MSChildNotification.NotificationDomain.Model.Dtos;

namespace MSChildNotification.NotificationDomain.Service.Interface
{
    public interface IOffenseTypeService
    {
        Task<OffenseTypeDto> GetOffenseTypeByCode(string offenseCode);
    }
}
