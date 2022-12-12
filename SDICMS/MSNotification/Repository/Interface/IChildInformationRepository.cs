using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Repository.Interface
{
    public interface IChildInformationRepository
    {
        Task<ChildInformation> GetChildInformationById(int childInformationId);
    }
}
