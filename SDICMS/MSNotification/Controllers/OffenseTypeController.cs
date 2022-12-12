using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSChildNotification.NotificationDomain.Service.Interface;

namespace MSChildNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseTypeController : ControllerBase
    {
        private IOffenseTypeService _offenseTypeService;

        public OffenseTypeController(IOffenseTypeService offenseTypeService)
        {
            _offenseTypeService = offenseTypeService;
        }

        [HttpGet("Code/{offenseCode}")]
        public async Task<IActionResult> GetOffenseTypeByCode(string offenseCode)
        {
            var childInformationResults = await _offenseTypeService.GetOffenseTypeByCode(offenseCode);
            return Ok(childInformationResults);
        }
    }
}
