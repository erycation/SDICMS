using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IDistrictService
    {
        Task<DistrictDto> GetDistrictById(int districtId);
        Task<List<DistrictDto>> GetDistrictByProvinceId(int provinceId);
    }
}
