using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly IProvinceService _provinceService;
        private readonly IDistrictService _districtService;

        public CountryController(ICountryService countryService, 
                                 IProvinceService provinceService,
                                 IDistrictService districtService)
        {
            _countryService = countryService;
            _provinceService = provinceService;
            _districtService = districtService;
        }

        [HttpGet("{countryId}")]
        public async Task<IActionResult> GetCountryById(int countryId)
        {
            var countryResults = await _countryService.GetCountryById(countryId);
            return Ok(countryResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetListOfCountries()
        {
            var countriesResults = await _countryService.GetListOfCountries();
            return Ok(countriesResults);
        }

        [HttpGet("Province/{countryId}")]
        public async Task<IActionResult> GetProvincesByCountryId(int countryId)
        {
            var provincesResults = await _provinceService.GetProvincesByCountryId(countryId);
            return Ok(provincesResults);
        }

        [HttpGet("Province/Get/{provinceId}")]
        public async Task<IActionResult> GetProvinceById(int provinceId)
        {
            var countriesResults = await _provinceService.GetProvinceById(provinceId);
            return Ok(countriesResults);
        }
        [HttpGet("Province/District/Get/{districtId}")]
        public async Task<IActionResult> GetDistrictById(int districtId)
        {
            var districtResults = await _districtService.GetDistrictById(districtId);
            return Ok(districtResults);
        }

        [HttpGet("Province/District/{provinceId}")]
        public async Task<IActionResult> GetDistrictByProvinceId(int provinceId)
        {
            var districtsResults = await _districtService.GetDistrictByProvinceId(provinceId);
            return Ok(districtsResults);
        }
    }
}