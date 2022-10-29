using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleById(int roleId);
        Task<List<Role>> GetListOfRoles();
        Task<Role> CreateRole(Role role);       
        Task<Role> UpdateRole(Role role);
    }
}
