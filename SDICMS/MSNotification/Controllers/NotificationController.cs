using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSChildNotification.NotificationDomain.Service.Interface;

namespace MSChildNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet("{supervisorName}")]
        public async Task<IActionResult> GetNotificationCasesBySupervisor(string supervisorName)
        {
            var notificationCasesResults = await _notificationService.GetNotificationCasesBySupervisor(supervisorName);
            return Ok(notificationCasesResults);
        }
    }
}
