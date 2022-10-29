using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ITownService
    {
        Task<TownDto> GetTownById(int townId);
        Task<List<TownDto>> GetTownByLocalMicipalilityId(int localMunicipalityId);
    }
}
