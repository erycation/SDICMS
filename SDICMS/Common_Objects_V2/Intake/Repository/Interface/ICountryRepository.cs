using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ICountryRepository
    {
        Task<Country> GetCountryById(int countryId);
        Task<List<Country>> GetListOfCountries();
    }
}
