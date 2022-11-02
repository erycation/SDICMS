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
        private readonly ISchoolService _schoolService;
        private readonly IGradeService _gradeService;

        public SchoolController(ISchoolTypeService schoolTypeService, 
                                ISchoolService schoolService, 
                                IGradeService gradeService)
        {
            _schoolTypeService = schoolTypeService;
            _schoolService = schoolService;
            _gradeService = gradeService;
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

        [HttpPost("Add")]
        public async Task<IActionResult> CreateSchool([FromBody] SchoolDto schoolDto)
        {
            var schoolResults = await _schoolService.CreateSchool(schoolDto);
            return Ok(new { message = $"Successfully created.", data = schoolResults });
        }

        [HttpGet("Get/{schoolId}")]
        public async Task<IActionResult> GetSchoolById(int schoolId)
        {
            var schoolResults = await _schoolService.GetSchoolById(schoolId);
            return Ok(schoolResults);
        }

        [HttpGet("GetAll/{schoolTypeId}")]
        public async Task<IActionResult> GetAllSchoolByType(int schoolTypeId)
        {
            var schoolResults = await _schoolService.GetAllSchoolByType(schoolTypeId);
            return Ok(schoolResults);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateSchool([FromBody] SchoolDto schoolDto)
        {
            var schoolResults = await _schoolService.UpdateSchool(schoolDto);
            return Ok(new { message = $"Successfully updated.", data = schoolResults });
        }

        [HttpGet("Grades")]
        public async Task<IActionResult> GetAllGrades()
        {
            var gradeResults = await _gradeService.GetAllGrades();
            return Ok(gradeResults);
        }
        
    }
}
