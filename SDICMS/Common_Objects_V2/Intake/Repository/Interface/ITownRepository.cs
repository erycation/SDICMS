using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ITownRepository
    {
        Task<Town> GetTownById(int townId);
        Task<List<Town>> GetTownByLocalMicipalilityId(int localMunicipalityId);
    }
}
