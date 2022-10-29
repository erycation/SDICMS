using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class TownRepository : IntakeRepository<LocalMunicipality>, ITownRepository
    {

        public TownRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Town> GetTownById(int townId)
        {
            return await _intakeDBContext.Towns.SingleOrDefaultAsync(t => t.Town_Id == townId);
        }

        public async Task<List<Town>> GetTownByLocalMicipalilityId(int localMunicipalityId)
        {
            return await _intakeDBContext.Towns.Where(t => t.Local_Municipality_Id == localMunicipalityId).ToListAsync();
        }
    }
}
