using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IPopulationGroupService
    {
        Task<PopulationGroupDto> GetPopulationGroupById(int populationGroupId);
        Task<List<PopulationGroupDto>> GetPopulationGroups();
    }
}
