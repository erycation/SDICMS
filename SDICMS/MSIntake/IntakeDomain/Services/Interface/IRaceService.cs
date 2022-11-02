using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IRaceService
    {
        Task<List<RaceDto>> GetAllRaces();
    }
}
