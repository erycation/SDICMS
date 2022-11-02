using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolTypeService _schoolTypeService;

        public SchoolController(ISchoolTypeService schoolTypeService)
        {
            _schoolTypeService = schoolTypeService;
        }

        [HttpPost("Type/Add")]
        public async Task<IActionResult> CreateSchoolType([FromBody] SchoolTypeDto schoolTypeDto)
        {
            var schoolTypeResults = await _schoolTypeService.CreateSchoolType(schoolTypeDto);
            return Ok(new { message = $"Successfully created.", data = schoolTypeResults });
        }

        [HttpGet("Type/Get/{schoolTypeId}")]
        public async Task<IActionResult> GetSchoolTypeById(int schoolTypeId)
        {
            var schoolTypeResults = await _schoolTypeService.GetSchoolTypeById(schoolTypeId);
            return Ok(schoolTypeResults);
        }

        [HttpGet("Type/GetAll")]
        public async Task<IActionResult> GetAllSchoolType()
        {
            var schoolTypeResults = await _schoolTypeService.GetAllSchoolType();
            return Ok(schoolTypeResults);
        }

        [HttpPut("Type/Update")]
        public async Task<IActionResult> UpdateSchoolType([FromBody] SchoolTypeDto schoolTypeDto)
        {
            var userResults = await _schoolTypeService.UpdateSchoolType(schoolTypeDto);
            return Ok(new { message = $"Successfully updated.", data = userResults });
        }
    }
}
