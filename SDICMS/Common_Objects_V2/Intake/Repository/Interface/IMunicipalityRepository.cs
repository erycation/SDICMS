using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IMunicipalityRepository
    {
        Task<District> GetDistrictById(int districtId);
        Task<List<District>> GetDistrictByProvinceId(int provinceId);
    }
}
