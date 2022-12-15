using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Model.Request;

namespace MSChildNotification.NotificationDomain.Service.Interface
{
    public interface ICaseInformationService
    {
        Task<CaseInformationDto> AssignCaseToProbationOfficer(RequestAssignCase requestAssignCase);
    }
}
