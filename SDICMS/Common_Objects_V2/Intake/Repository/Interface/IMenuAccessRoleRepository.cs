using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IMenuAccessRoleRepository
    {
        Task<List<MenuAccessRole>> GetMenuAccessByRoleId(int roleId);
        Task<MenuAccessRole> CreateMenuAccess(MenuAccessRole menuAccessRole);
        void CreateBulkMenuAccessRole(List<MenuAccessRole> menuAccessRoles);
        Task<MenuAccessRole> UpdateMenuAccess(MenuAccessRole menuAccessRole);
        Task<MenuAccessRole> DeleteMenuAccess(MenuAccessRole menuAccessRole);
    }
}
