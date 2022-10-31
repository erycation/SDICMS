using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class MenuAccessRoleRepository : IntakeRepository<MenuAccessRole>, IMenuAccessRoleRepository
    {

        public MenuAccessRoleRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async void CreateBulkMenuAccessRole(List<MenuAccessRole> menuAccessRoles)
        {
            foreach(var menuAccessRole in menuAccessRoles)
            {
                await _intakeDBContext.MenuAccessRoles.AddAsync(menuAccessRole);
                
            }
            await _intakeDBContext.SaveChangesAsync();
        }

        public async Task<MenuAccessRole> CreateMenuAccess(MenuAccessRole menuAccessRole)
        {
            await _intakeDBContext.MenuAccessRoles.AddAsync(menuAccessRole);
            await _intakeDBContext.SaveChangesAsync();
            return menuAccessRole;
        }

        public async Task<MenuAccessRole> DeleteMenuAccess(MenuAccessRole menuAccessRole)
        {
            await _intakeDBContext.MenuAccessRoles.AddAsync(menuAccessRole);
            await _intakeDBContext.SaveChangesAsync();
            return menuAccessRole;
        }

        public async Task<List<MenuAccessRole>> GetMenuAccessByRoleId(int roleId)
        {
            return await _intakeDBContext.MenuAccessRoles.Where(m => m.Role_Id == roleId).ToListAsync();
        }

        public Task<MenuAccessRole> UpdateMenuAccess(MenuAccessRole menuAccessRole)
        {
            throw new NotImplementedException();
        }

        //public async Task<MenuAccess> CreateMenuAccess(MenuAccess menuAccess)
        //{
        //    await _intakeDBContext.MenuAccess.AddAsync(menuAccess);
        //    await _intakeDBContext.SaveChangesAsync();
        //    return menuAccess;
        //}

        //public async Task<MenuAccess> GetMenuAccessByName(string description)
        //{
        //    return await _intakeDBContext.MenuAccess.SingleOrDefaultAsync(m => m.Description == description);
        //}

        //public async Task<List<MenuAccess>> GetMenuAccessByParentId(int parentId)
        //{
        //    return await _intakeDBContext.MenuAccess.Where(m => m.ParentId == parentId).ToListAsync();
        //}

        //public async Task<List<MenuAccess>> GetModules()
        //{
        //    return await _intakeDBContext.MenuAccess.Where(m => m.IsModule).ToListAsync();
        //}

        //public async Task<MenuAccess> UpdateMenuAccess(MenuAccess menuAccess)
        //{
        //    _intakeDBContext.MenuAccess.Update(menuAccess);
        //    await _intakeDBContext.SaveChangesAsync();
        //    return menuAccess;
        //}
    }
}
