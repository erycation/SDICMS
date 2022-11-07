using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class AuditTrialRepository : IntakeRepository<AuditTrial>, IAuditTrialRepository
    {

        public AuditTrialRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<AuditTrial> CreateAuditTrial(AuditTrial auditTrial)
        {
            await _intakeDBContext.AuditTrials.AddAsync(auditTrial);
            await _intakeDBContext.SaveChangesAsync();
            return auditTrial;
        }

        public async Task<AuditTrial> GetAuditTrialById(int auditTrailId)
        {
            return await _intakeDBContext.AuditTrials.SingleOrDefaultAsync(a => a.Apl_AuditTrial_Id == auditTrailId);
        }

        public async Task<List<AuditTrial>> GetAuditTrials()
        {
            return await _intakeDBContext.AuditTrials.ToListAsync();
        }
    }
}