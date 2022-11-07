using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IAuditTrialRepository
    {
        Task<AuditTrial> CreateAuditTrial(AuditTrial auditTrial);
        Task<AuditTrial> GetAuditTrialById(int auditTrailId);
        Task<List<AuditTrial>> GetAuditTrials();
    }
}
 