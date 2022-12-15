using Microsoft.EntityFrameworkCore;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.Persistence;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.Repository
{
    public class CaseInformationRepository : Repository<CaseInformation>, ICaseInformationRepository
    {

        public CaseInformationRepository(ChildNotificationDBContext childNotificationDBContext) : base(childNotificationDBContext)
        {

        }

        public async Task<CaseInformation> AddCaseInformation(CaseInformation caseInformation)
        {
            await _childNotificationDBContext.CaseInformations.AddAsync(caseInformation);
            await _childNotificationDBContext.SaveChangesAsync();
            return caseInformation;
        }

        public async Task<CaseInformation> UpdateCaseInformation(CaseInformation caseInformation)
        {
            _childNotificationDBContext.CaseInformations.Update(caseInformation);
            await _childNotificationDBContext.SaveChangesAsync();
            return caseInformation;
        }

        public async Task<CaseInformation> GetCaseInformationById(int caseInformationId)
        {
            return await _childNotificationDBContext.CaseInformations.SingleOrDefaultAsync(c => c.CaseInformationID == caseInformationId);
        }

    }
}