using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinkedDeviceController : ControllerBase
    {
        private readonly ILinkedDeviceService _linkedDeviceService;

        public LinkedDeviceController(ILinkedDeviceService linkedDeviceService)
        {
            _linkedDeviceService = linkedDeviceService;
        }

        [HttpGet("Active/{deviceId}")]
        public async Task<IActionResult> GetActiveLinkedDeviceByDeviceId(string deviceId)
        {
            var linkedDeviceResults = await _linkedDeviceService.GetActiveLinkedDeviceByDeviceId(deviceId);
            return Ok(linkedDeviceResults);
        }

        [HttpGet("All/{userId}")]
        public async Task<IActionResult> GetLinkedDevicesByDeviceId(int userId)
        {
            var linkedDeviceResults = await _linkedDeviceService.GetLinkedDevicesByDeviceId(userId);
            return Ok(linkedDeviceResults);
        }
    }
}