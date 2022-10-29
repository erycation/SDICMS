using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RoleDto roleDto)
        {
            var roleResults = await _roleService.CreateRole(roleDto);
            return Ok(new { message = $"Successfully created.", data = roleResults });
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetCountryById(int roleId)
        {
            var roleResults = await _roleService.GetRoleById(roleId);
            return Ok(roleResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetListOfRoles()
        {
            var rolesResults = await _roleService.GetListOfRoles();
            return Ok(rolesResults);
        }

        [HttpPut("Activate")]
        public async Task<IActionResult> ActivateRole([FromBody] RoleDto roleDto)
        {
            var roleResults = await _roleService.SetRoleIsActive(roleDto);
            return Ok(new { message = $"Successfully activated.", data = roleResults });
        }

        [HttpPut("DeleteRole")]
        public async Task<IActionResult> DeleteRole([FromBody] RoleDto roleDto)
        {
            var roleResults = await _roleService.SetRoleIsDeleted(roleDto);
            return Ok(new { message = $"Successfully deleted.", data = roleResults });
        }
    }
}
