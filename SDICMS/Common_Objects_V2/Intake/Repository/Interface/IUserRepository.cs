using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserDetailsByUsername(string username);
        Task<User> GetUserDetailsById(int userId);
        Task<List<User>> GetAllUsers();
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
    }
}
