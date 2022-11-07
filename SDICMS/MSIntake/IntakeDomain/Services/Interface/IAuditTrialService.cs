using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IAuditTrialService
    {
        Task<AuditTrialDto> CreateAuditTrial(AuditTrialDto auditTrialDto);
        Task<AuditTrialDto> GetAuditTrialById(int auditTrailId);
        Task<List<AuditTrialDto>> GetAuditTrials();
    }
}
