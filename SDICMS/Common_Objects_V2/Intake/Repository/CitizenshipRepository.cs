using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class CitizenshipRepository : IntakeRepository<Citizenship>, ICitizenshipRepository
    {

        public CitizenshipRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Citizenship> GetCitizenshipById(int citizenId)
        {
            return await _intakeDBContext.Citizenships.SingleOrDefaultAsync(c => c.Citizenship_Id == citizenId);
        }

        public async Task<List<Citizenship>> GetCitizenships()
        {
            return await _intakeDBContext.Citizenships.ToListAsync();
        }
    }
}