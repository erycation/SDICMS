using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinicipalityController : ControllerBase
    {
        private readonly ILocalMunicipalityService _localMunicipalityService;
        private readonly ITownService _townService;
        private readonly IOrganizationService _organizationService;

        public MinicipalityController(ILocalMunicipalityService localMunicipalityService,
            ITownService townService,
            IOrganizationService organizationService)
        {
            _localMunicipalityService = localMunicipalityService;
            _townService = townService;
            _organizationService = organizationService;
        }

        [HttpGet("Local/{localMunicipalityId}")]
        public async Task<IActionResult> GetLocalMunicipalityById(int localMunicipalityId)
        {
            var localMunicipalityResults = await _localMunicipalityService.GetLocalMunicipalityById(localMunicipalityId);
            return Ok(localMunicipalityResults);
        }

        [HttpGet("Local/District/{districtId}")]
        public async Task<IActionResult> GetLocalMunicipalitiesByDistrictId(int districtId)
        {
            var localMunicipalitiesResults = await _localMunicipalityService.GetLocalMunicipalitiesByDistrictId(districtId);
            return Ok(localMunicipalitiesResults);
        }

        [HttpGet("Local/Town/{townId}")]
        public async Task<IActionResult> GetTownById(int townId)
        {
            var townResults = await _townService.GetTownById(townId);
            return Ok(townResults);
        }

        [HttpGet("Local/Town/All/{localMunicipalityId}")]
        public async Task<IActionResult> GetTownByLocalMicipalilityId(int localMunicipalityId)
        {
            var townResults = await _townService.GetTownByLocalMicipalilityId(localMunicipalityId);
            return Ok(townResults);
        }

        [HttpGet("Local/Organization/{organizationId}")]
        public async Task<IActionResult> GetOrganizationById(int organizationId)
        {
            var organizationResults = await _organizationService.GetOrganizationById(organizationId);
            return Ok(organizationResults);
        }

        [HttpGet("Local/Organization/All/{localMunicipalityId}")]
        public async Task<IActionResult> GetOrganizationByLocalMicipalilityId(int localMunicipalityId)
        {
            var organizationResults = await _organizationService.GetOrganizationByLocalMicipalilityId(localMunicipalityId);
            return Ok(organizationResults);
        }


    }
}