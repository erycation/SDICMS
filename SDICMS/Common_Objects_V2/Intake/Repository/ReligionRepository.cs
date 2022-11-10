using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class ReligionRepository : IntakeRepository<Religion>, IReligionRepository
    {

        public ReligionRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<List<Religion>> GetAllReligions()
        {
            return await _intakeDBContext.Religions.ToListAsync();
        }

        public async Task<Religion> GetReligionById(int religionId)
        {
            return await _intakeDBContext.Religions.SingleOrDefaultAsync(r => r.Religion_Id == religionId);
        }
    }
}