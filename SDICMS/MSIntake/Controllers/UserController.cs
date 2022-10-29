﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto userDto)
        {
            var userResults = await _usersService.CreateUser(userDto);
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
    }
}
