using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class GroupRepository : IntakeRepository<Group>, IGroupRepository
    {

        public GroupRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public Task<Group> CreateGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public async Task<Group> GetGroupById(int groupId)
        {
            return await _intakeDBContext.Groups.SingleOrDefaultAsync(g => g.Group_Id == groupId);
        }

        public async Task<List<Group>> GetListOfGroups()
        {
            return await _intakeDBContext.Groups.Where(g => g.Is_Deleted == false && g.Is_Active == true).ToListAsync();
        }

        public Task<Group> SetGroupIsActive(Group group)
        {
            throw new NotImplementedException();
        }

        public Task<Group> SetGroupIsDeleted(Group group)
        {
            throw new NotImplementedException();
        }

        //public async Task<User> GetUserDetailsByUsername(string username)
        //{
        //    return await _intakeDBContext.Users.SingleOrDefaultAsync(u => u.User_Name == username);
        //}
    }
}

