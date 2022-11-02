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

        /*
         return Context.TblNumbers
              .Where(m => m.Number != null)
              .Where(m => convertedNumbers.Contains(m.Number.Value))
              .Select(m => m.Number.Value)
              .ToList(); 
         */

        public async Task<List<MenuAccess>> GetMenuAccessByRolesId(List<int> roleIds)
        {
            return await (from m in _intakeDBContext.MenuAccess
                          join ma in _intakeDBContext.MenuAccessRoles
                          on m.Menu_Access_Id equals ma.Menu_Access_Id
                          where roleIds.Contains(ma.Role_Id)
                          select m).ToListAsync();

            //return await _intakeDBContext.MenuAccess.Where(m => m.MenuAccessRoles.Contains(x )).ToListAsync();
        }
        /*
         var person = (from p in db.People
                  join e in db.EmailAddresses
                  on p.BusinessEntityID equals e.BusinessEntityID
                  where p.FirstName == "KEN"
                  select new { 
                               ID = p.BusinessEntityID, 
                               FirstName = p.FirstName, 
                               MiddleName = p.MiddleName, 
                               LastName = p.LastName, 
                               EmailID = e.EmailAddress1 
                  }).ToList();
         */
    }
}
