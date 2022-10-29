using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IRoleService
    {
        Task<RoleDto> GetRoleById(int roleId);
        Task<List<RoleDto>> GetListOfRoles();
        Task<RoleDto> CreateRole(RoleDto roleDto);
        Task<RoleDto> SetRoleIsActive(RoleDto roleDto);
        Task<RoleDto> SetRoleIsDeleted(RoleDto roleDto);
    }
}
