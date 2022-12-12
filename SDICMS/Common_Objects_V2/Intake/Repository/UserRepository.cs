

using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class UserRepository : IntakeRepository<User>, IUserRepository
    {

        public UserRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<User> CreateUser(User user)
        {
            await _intakeDBContext.Users.AddAsync(user);
            await _intakeDBContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _intakeDBContext.Users.ToListAsync();
        }

        public async Task<User> GetUserDetailsByUsername(string username)
        {
            return await _intakeDBContext.Users.SingleOrDefaultAsync(u => u.User_Name == username);
        }

        public async Task<User> GetUserDetailsById(int userId)
        {
            return await _intakeDBContext.Users.SingleOrDefaultAsync(u => u.User_Id == userId);
        }

        public async Task<User> UpdateUser(User user)
        {
            _intakeDBContext.Users.Update(user);
            await _intakeDBContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<ProbationOfficer>> GetProbationOfficersBySupervisorId(int supervisorId)
        {
            return await _intakeDBContext.ProbationOfficers.FromSqlRaw("INTAKE_GetProbationOfficerBySupervisorId @supervisorId",
                                                                       new SqlParameter("@supervisorId", supervisorId)).ToListAsync();
        }
    }
}

