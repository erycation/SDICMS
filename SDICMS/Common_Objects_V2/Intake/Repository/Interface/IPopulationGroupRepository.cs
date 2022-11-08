using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IPopulationGroupRepository
    {
        Task<PopulationGroup> GetPopulationGroupById(int populationGroupId);
        Task<List<PopulationGroup>> GetPopulationGroups();
    }
}
