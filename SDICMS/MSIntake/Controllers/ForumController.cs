using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private IAuthenticateService _authenticateService;

        public ForumController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Credentials credentials)
        {
            var token = await _authenticateService.Login(credentials);

            if (!token.Success)
                return BadRequest(new { message = token.Message });

            return Ok(token);
        }
    }
}
