using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class DeceaseRepository : IntakeRepository<Decease>, IDeceaseRepository
    {

        public DeceaseRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Decease> GetDeceaseById(int deceaseId)
        {
            return await _intakeDBContext.Deceases.SingleOrDefaultAsync(d => d.Decease_Id == deceaseId);
        }

        public async Task<List<Decease>> GetDeceases()
        {
            return await _intakeDBContext.Deceases.ToListAsync();
        }
    }
}