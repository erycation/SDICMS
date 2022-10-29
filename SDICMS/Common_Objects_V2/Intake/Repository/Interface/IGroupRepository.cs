using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IGroupRepository
    {
        Task<Group> GetGroupById(int groupId);
        Task<List<Group>> GetListOfGroups();
        Task<Group> CreateGroup(Group group);
        Task<Group> SetGroupIsActive(Group group);
        Task<Group> SetGroupIsDeleted(Group group);
    }
}
