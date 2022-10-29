using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IUsersService
    {
        Task<UserDto> GetUserDetailsByUsername(string username);
        Task<UserDto> GetUserDetailsById(int userId);
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto> CreateUser(UserDto userDto);
        Task<UserDto> UpdateUser(UserDto userDto);
        Task<UserDto> ChangePassword(UserDto userDto);
        Task<UserDto> ActivateUser(UserDto userDto);
        Task<UserDto> DeleteUser(UserDto userDto);
    }
}
