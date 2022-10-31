using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IMenuAccessRepository
    {
        Task<MenuAccess> GetMenuAccessByName(string description);
        Task<MenuAccess> GetMenuAccessById(int menuAccessId);
        Task<List<MenuAccess>> GetModules();
        Task<List<MenuAccess>> GetMenuAccessByParentId(int parentId);
        Task<MenuAccess> CreateMenuAccess(MenuAccess menuAccess);
        Task<MenuAccess> UpdateMenuAccess(MenuAccess menuAccess);
    }
}
