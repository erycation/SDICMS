using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class MenuAccessRepository : IntakeRepository<MenuAccess>, IMenuAccessRepository
    {

        public MenuAccessRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<MenuAccess> CreateMenuAccess(MenuAccess menuAccess)
        {
            await _intakeDBContext.MenuAccess.AddAsync(menuAccess);
            await _intakeDBContext.SaveChangesAsync();
            return menuAccess;
        }

        public async Task<MenuAccess> GetMenuAccessByName(string description)
        {
            return await _intakeDBContext.MenuAccess.SingleOrDefaultAsync(m => m.Description == description);
        }

        public async Task<MenuAccess> GetMenuAccessById(int menuAccessId)
        {
            return await _intakeDBContext.MenuAccess.SingleOrDefaultAsync(m => m.Menu_Access_Id == menuAccessId);
        }

        public async Task<List<MenuAccess>> GetMenuAccessByParentId(int parentId)
        {
            return await _intakeDBContext.MenuAccess.Where(m => m.ParentId == parentId).ToListAsync();
        }

        public async Task<List<MenuAccess>> GetModules()
        {
            return await _intakeDBContext.MenuAccess.Where(m => m.IsModule).ToListAsync();
        }

        public async Task<MenuAccess> UpdateMenuAccess(MenuAccess menuAccess)
        {
            _intakeDBContext.MenuAccess.Update(menuAccess);
            await _intakeDBContext.SaveChangesAsync();
            return menuAccess;
        }
    }
}
