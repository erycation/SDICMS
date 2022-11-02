using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpController : ControllerBase
    {
        private readonly IGenderService _genderService;
        private readonly IMaritalStatusService _maritalStatusService;
        private readonly IRaceService _raceService;
        private readonly IReligionService _religionService;
        private readonly ISkinColorService _skinColorService;

        public LookUpController(IGenderService genderService,
                                IMaritalStatusService maritalStatusService,
                                IRaceService raceService,
                                IReligionService religionService,
                                ISkinColorService skinColorService)
        {
            _genderService = genderService;
            _maritalStatusService = maritalStatusService;
            _raceService = raceService;
            _religionService = religionService;
            _skinColorService = skinColorService;
        }

        [HttpGet("Gender")]
        public async Task<IActionResult> GetGenders()
        {
            var genderResults = await _genderService.GetGenders();
            return Ok(genderResults);
        }

        [HttpGet("MaritalStatus/Get/{maritalStatusId}")]
        public async Task<IActionResult> GetMaritalStatus(int maritalStatusId)
        {
            var maritalStatusResults = await _maritalStatusService.GetMaritalStatuById(maritalStatusId);
            return Ok(maritalStatusResults);
        }

        [HttpGet("MaritalStatus")]
        public async Task<IActionResult> GetMaritalStatus()
        {
            var maritalStatusResults = await _maritalStatusService.GetMaritalStatus();
            return Ok(maritalStatusResults);
        }

        [HttpGet("Race")]
        public async Task<IActionResult> GetAllRaces()
        {
            var raceResults = await _raceService.GetAllRaces();
            return Ok(raceResults);
        }

        [HttpGet("Religions")]
        public async Task<IActionResult> GetAllReligions()
        {
            var religionResults = await _religionService.GetAllReligions();
            return Ok(religionResults);
        }

        [HttpGet("SkinColor")]
        public async Task<IActionResult> GetAllSkinColors()
        {
            var skinColorResults = await _skinColorService.GetAllSkinColors();
            return Ok(skinColorResults);
        }
    }
}
