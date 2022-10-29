using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ILocalMunicipalityRepository
    {
        Task<LocalMunicipality> GetLocalMunicipalityById(int localMunicipalityId);
        Task<List<LocalMunicipality>> GetLocalMunicipalitiesByDistrictId(int districtId);
    }
}
