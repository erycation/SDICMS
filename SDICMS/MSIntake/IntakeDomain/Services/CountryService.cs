using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CountryService(IMapper mapper,
                            ICountryRepository countryRepository)
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
        }

        public async Task<CountryDto> GetCountryById(int countryId)
        {
            var responseCountry = await _countryRepository.GetCountryById(countryId);
            return _mapper.Map<CountryDto>(responseCountry);
        }

        public async Task<List<CountryDto>> GetListOfCountries()
        {
            var responseCountries = await _countryRepository.GetListOfCountries();
            return _mapper.Map<List<CountryDto>>(responseCountries);
        }
    }
}
