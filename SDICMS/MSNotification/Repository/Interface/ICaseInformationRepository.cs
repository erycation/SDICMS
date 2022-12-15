using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Repository.Interface
{
    public interface ICaseInformationRepository
    {
        Task<CaseInformation> AddCaseInformation(CaseInformation caseInformation);
        Task<CaseInformation> UpdateCaseInformation(CaseInformation caseInformation);
        Task<CaseInformation> GetCaseInformationById(int caseInformationId);
    }
}
