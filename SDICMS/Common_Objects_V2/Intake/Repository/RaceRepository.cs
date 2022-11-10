using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class RaceRepository : IntakeRepository<Race>, IRaceRepository
    {

        public RaceRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<List<Race>> GetAllRaces()
        {
            return await _intakeDBContext.Races.ToListAsync();
        }

        public async Task<Race> GetRaceById(int raceId)
        {
            return await _intakeDBContext.Races.SingleOrDefaultAsync(r => r.Race_Id == raceId);
        }
    }
}