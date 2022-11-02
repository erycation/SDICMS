using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class MaritalStatusRepository : IntakeRepository<MaritalStatus>, IMaritalStatusRepository
    {

        public MaritalStatusRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<MaritalStatus> GetMaritalStatuById(int maritalStatusId)
        {
            return await _intakeDBContext.MaritalStatuss.SingleOrDefaultAsync(m => m.Marital_Status_Id == maritalStatusId);
        }

        public async Task<List<MaritalStatus>> GetMaritalStatus()
        {
            return await _intakeDBContext.MaritalStatuss.ToListAsync();
        }
    }
}