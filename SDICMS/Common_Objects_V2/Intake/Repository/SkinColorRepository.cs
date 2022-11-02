using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class SkinColorRepository : IntakeRepository<Race>, ISkinColorRepository
    {

        public SkinColorRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<List<SkinColor>> GetAllSkinColors()
        {
            return await _intakeDBContext.SkinColors.ToListAsync();
        }
    }
}