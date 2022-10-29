using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IProvinceRepository
    {
        Task<Province> GetProvinceById(int provinceId);
        Task<List<Province>> GetProvincesByCountryId(int countryId);
    }
}
