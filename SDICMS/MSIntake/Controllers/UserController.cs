using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] RegisterUser registerUser)
        {
            var userResults = await _usersService.CreateUser(registerUser);
            return Ok(new { message = $"Successfully created.", data = userResults });
        }

        [HttpGet("details/{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var userResults = await _usersService.GetUserDetailsById(userId);
            return Ok(userResults);
        }

        [HttpGet("Get/{username}")]
        public async Task<IActionResult> GetUserDetailsByUsername(string username)
        {
            var userResults = await _usersService.GetUserDetailsByUsername(username);
            return Ok(userResults);
        }


        //[HttpGet("Mobile/{deviceId}")]
        //public async Task<IActionResult> GetUserDetailsByDeviceId(string deviceId)
        //{
        //    var userResults = await _usersService.GetUserDetailsByDeviceId(deviceId);
        //    return Ok(userResults);
        //}

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllUsers()
        {
            var userResults = await _usersService.GetAllUsers();
            return Ok(userResults);
        }

        [HttpPut("Activate")]
        public async Task<IActionResult> ActivateUser([FromBody] UserDto userDto)
        {
            var userResults = await _usersService.ActivateUser(userDto);
            return Ok(new { message = $"Successfully activated.", data = userResults });
        }

        [HttpPut("DeleteUser")]
        public async Task<IActionResult> DeleteUser([FromBody] UserDto userDto)
        {
            var userResults = await _usersService.DeleteUser(userDto);
            return Ok(new { message = $"Successfully deleted.", data = userResults });
        }

        [HttpPut("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ChangePassword changePassword)
        {
            var userResults = await _usersService.ResetPassword(changePassword);
            return Ok(new { message = $"Password successfully updated.", data = userResults });
        }
    }
}
