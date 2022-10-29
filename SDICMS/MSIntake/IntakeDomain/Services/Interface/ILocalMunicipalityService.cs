using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ILocalMunicipalityService
    {
        Task<LocalMunicipalityDto> GetLocalMunicipalityById(int localMunicipalityId);
        Task<List<LocalMunicipalityDto>> GetLocalMunicipalitiesByDistrictId(int districtId);
    }
}
