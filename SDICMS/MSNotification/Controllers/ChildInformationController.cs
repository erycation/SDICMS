using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSChildNotification.NotificationDomain.Service.Interface;

namespace MSChildNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildInformationController : ControllerBase
    {
        private IChildInformationService _childInformationService;

        public ChildInformationController(IChildInformationService childInformationService)
        {
            _childInformationService = childInformationService;
        }

        [HttpGet("Get/{childInformationById}")]
        public async Task<IActionResult> GetChildInformationById(int childInformationById)
        {
            var childInformationResults = await _childInformationService.GetChildInformationById(childInformationById);
            return Ok(childInformationResults);
        }
    }
}
