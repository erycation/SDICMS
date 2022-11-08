using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class PopulationGroupRepository : IntakeRepository<PopulationGroup>, IPopulationGroupRepository
    {

        public PopulationGroupRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<PopulationGroup> GetPopulationGroupById(int populationGroupId)
        {
            return await _intakeDBContext.PopulationGroups.SingleOrDefaultAsync(p => p.Population_Group_Id == populationGroupId);
        }

        public async Task<List<PopulationGroup>> GetPopulationGroups()
        {
            return await _intakeDBContext.PopulationGroups.ToListAsync();
        }
    }
}