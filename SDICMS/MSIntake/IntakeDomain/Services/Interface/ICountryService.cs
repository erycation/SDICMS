using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ICountryService
    {
        Task<CountryDto> GetCountryById(int countryId);
        Task<List<CountryDto>> GetListOfCountries();
    }
}
