using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class DisabilityRepository : IntakeRepository<Disability>, IDisabilityRepository
    {

        public DisabilityRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Disability> GetDisabilityById(int disabilityId)
        {
            return await _intakeDBContext.Disabilities.SingleOrDefaultAsync(d => d.Disability_Id == disabilityId);
        }

        public async Task<List<Disability>> GetDisabilities()
        {
            return await _intakeDBContext.Disabilities.ToListAsync();
        }
    }
}