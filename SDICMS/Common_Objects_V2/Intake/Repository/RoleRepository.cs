

using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class RoleRepository : IntakeRepository<Role>, IRoleRepository
    {

        public RoleRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Role> CreateRole(Role role)
        {
            await _intakeDBContext.Roles.AddAsync(role);
            await _intakeDBContext.SaveChangesAsync();
            return role;
        }

        public async Task<List<Role>> GetListOfRoles()
        {
            return await _intakeDBContext.Roles.Where(r => r.Is_Deleted == false && r.Is_Active == true).ToListAsync();
        }

        public async Task<Role> GetRoleById(int roleId)
        {
            return await _intakeDBContext.Roles.SingleOrDefaultAsync(r => r.Role_Id == roleId);
        }

        public async Task<Role> UpdateRole(Role role)
        {
            _intakeDBContext.Roles.Update(role);
            await _intakeDBContext.SaveChangesAsync();
            return role;
        }
    }
}

