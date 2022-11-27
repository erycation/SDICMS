using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Model.Response;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IUsersService
    {
        Task<UserDto> GetUserDetailsByUsername(string username);
        Task<UserDto> GetUserDetailsById(int userId);
        //Task<MobileResponse> GetUserDetailsByDeviceId(string deviceId);
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto> CreateUser(RegisterUser registerUser);
        Task<UserDto> UpdateUser(UserDto userDto);
        Task<UserDto> AuthenticateUser(Credentials credentials);
        Task<UserDto> MobileAuthenticate(MobileCredentials mobileCredentials);
        Task<UserDto> LoginToLinkDevice(LinkUserToMobile linkUserToMobile);
        Task<UserDto> ResetPassword(ChangePassword changePassword);
        Task<UserDto> ActivateUser(UserDto userDto);
        Task<UserDto> DeleteUser(UserDto userDto);
    }
}
