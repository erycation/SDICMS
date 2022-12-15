using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSChildNotification.NotificationDomain.Model.Request;
using MSChildNotification.NotificationDomain.Service.Interface;

namespace MSChildNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseInformationController : ControllerBase
    {
        private ICaseInformationService _caseInformationService;

        public CaseInformationController(ICaseInformationService caseInformationService)
        {
            _caseInformationService = caseInformationService;
        }

        [HttpPost("AssignCaseToPoc")]
        public async Task<IActionResult> AssignCaseToPoc([FromBody] RequestAssignCase requestAssignCase)
        {
            var caseAssignedResults = await _caseInformationService.AssignCaseToProbationOfficer(requestAssignCase);
            return Ok(new { message = $"Case successfully assigned.", data = caseAssignedResults });
        }
    }
}
