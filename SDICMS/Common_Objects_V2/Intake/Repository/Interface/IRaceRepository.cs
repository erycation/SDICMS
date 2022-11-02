using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IRaceRepository
    {
        Task<List<Race>> GetAllRaces();
    }
}
