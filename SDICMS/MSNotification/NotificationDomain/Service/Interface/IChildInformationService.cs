using MSChildNotification.NotificationDomain.Model.Dtos;

namespace MSChildNotification.NotificationDomain.Service.Interface
{
    public interface IChildInformationService
    {
        Task<ChildInformationDto> GetChildInformationById(int childInformationId);
    }
}
