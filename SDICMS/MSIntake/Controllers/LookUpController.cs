﻿using Microsoft.AspNetCore.Http;
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
        private readonly IAllergyService _allergyService;
        private readonly IContactTypeService _contactTypeService;
        private readonly ICitizenshipService _citizenshipService;
        private readonly IPopulationGroupService _populationGroupService;
        private readonly IRelationshipTypeService _relationshipTypeService;
        private readonly IIncomeRangeService _incomeRangeService;

        public LookUpController(IGenderService genderService,
                                IMaritalStatusService maritalStatusService,
                                IRaceService raceService,
                                IReligionService religionService,
                                ISkinColorService skinColorService,
                                IAllergyService allergyService,
                                IContactTypeService contactTypeService,
                                ICitizenshipService citizenshipService,
                                IPopulationGroupService populationGroupService,
                                IRelationshipTypeService relationshipTypeService,
                                IIncomeRangeService incomeRangeService)
        {
            _genderService = genderService;
            _maritalStatusService = maritalStatusService;
            _raceService = raceService;
            _religionService = religionService;
            _skinColorService = skinColorService;
            _allergyService = allergyService;
            _contactTypeService = contactTypeService;
            _citizenshipService = citizenshipService;
            _populationGroupService = populationGroupService;
            _relationshipTypeService = relationshipTypeService;
            _incomeRangeService = incomeRangeService;
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

        [HttpGet("Allergy/Get/{allergyId}")]
        public async Task<IActionResult> GetAllergyById(int allergyId)
        {
            var allergyResults = await _allergyService.GetAllergyById(allergyId);
            return Ok(allergyResults);
        }

        [HttpGet("Allergy")]
        public async Task<IActionResult> GetAllergies()
        {
            var allergyResults = await _allergyService.GetAllergies();
            return Ok(allergyResults);
        }

        [HttpGet("ContactType/Get/{contactTypeId}")]
        public async Task<IActionResult> GetContactTypeById(int contactTypeId)
        {
            var contactTypesResults = await _contactTypeService.GetContactTypeById(contactTypeId);
            return Ok(contactTypesResults);
        }

        [HttpGet("ContactType")]
        public async Task<IActionResult> GetContactTypes()
        {
            var contactTypesResults = await _contactTypeService.GetContactTypes();
            return Ok(contactTypesResults);
        }

        [HttpGet("Citizenship/Get/{citizenshipId}")]
        public async Task<IActionResult> GetCitizenshipById(int citizenshipId)
        {
            var citizenshipResults = await _citizenshipService.GetCitizenshipById(citizenshipId);
            return Ok(citizenshipResults);
        }

        [HttpGet("Citizenship")]
        public async Task<IActionResult> GetCitizenships()
        {
            var citizenshipResults = await _citizenshipService.GetCitizenships();
            return Ok(citizenshipResults);
        }

        [HttpGet("PopulationGroup/Get/{populationGroupId}")]
        public async Task<IActionResult> GetPopulationGroupById(int populationGroupId)
        {
            var populationGroupResults = await _populationGroupService.GetPopulationGroupById(populationGroupId);
            return Ok(populationGroupResults);
        }

        [HttpGet("PopulationGroup")]
        public async Task<IActionResult> GetPopulationGroups()
        {
            var populationGroupResults = await _populationGroupService.GetPopulationGroups();
            return Ok(populationGroupResults);
        }

        [HttpGet("RelationshipType/Get/{relationshipTypeId}")]
        public async Task<IActionResult> GetRelationshipTypeById(int relationshipTypeId)
        {
            var relationshipTypeResults = await _relationshipTypeService.GetRelationshipTypeById(relationshipTypeId);
            return Ok(relationshipTypeResults);
        }

        [HttpGet("RelationshipType")]
        public async Task<IActionResult> GetRelationshipTypes()
        {
            var relationshipTypeResults = await _relationshipTypeService.GetRelationshipTypes();
            return Ok(relationshipTypeResults);
        }

        [HttpGet("IncomeRange/Get/{incomeRangeId}")]
        public async Task<IActionResult> GetIncomeRangeById(int incomeRangeId)
        {
            var incomeRangeResults = await _incomeRangeService.GetIncomeRangeById(incomeRangeId);
            return Ok(incomeRangeResults);
        }

        [HttpGet("IncomeRange")]
        public async Task<IActionResult> GetIncomeRanges()
        {
            var incomeRangeResults = await _incomeRangeService.GetIncomeRanges();
            return Ok(incomeRangeResults);
        }
    }
}
