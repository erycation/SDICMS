using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IProvinceService
    {
        Task<ProvinceDto> GetProvinceById(int provinceId);
        Task<List<ProvinceDto>> GetProvincesByCountryId(int countryId);
    }
}
