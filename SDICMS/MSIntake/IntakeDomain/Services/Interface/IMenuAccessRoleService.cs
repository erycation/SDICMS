using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IMenuAccessRoleService
    {
        void CreateBulkMenuAccessRole(List<MenuAccessRoleDto> menuAccessRoleDtos);
    }
}
