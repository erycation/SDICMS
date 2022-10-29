using BCryptNet = BCrypt.Net.BCrypt;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class AuthenticateService : IAuthenticateService
    {

        private readonly IUsersService _userService;
        private readonly IAuthManager _authManager;

        public AuthenticateService(IUsersService userService,
                                     IAuthManager authManager)
        {
            _userService = userService;
            _authManager = authManager;
        }

        public async Task<AuthToken> Login(Credentials credentials)
        {

            var authToken = new AuthToken();
            var userResponse = await _userService.GetUserDetailsByUsername(credentials.Username);

            if (userResponse == null)
                throw new AppException($"Username {credentials.Username} not found.");

            //validate Password

            authToken.Username = userResponse.User_Name;
            authToken.UserId = userResponse.User_Id;
            authToken.Success = true;
            authToken.Firstname = userResponse.First_Name;
            authToken.Surname = userResponse.Last_Name;
            authToken.Token = _authManager.Authenticate(credentials.Username);
            authToken.UserRoleDtos = userResponse.UserRoleDtos;

            //if (userResponse == null || !BCryptNet.Verify(credentials.Password, userResponse.Password))
            //{
            //    authToken.Message = $"Username or password is incorrect";
            //}
            //else if (userResponse.Active == false)
            //{
            //    authToken.Message = $"Account is locked";
            //}
            //else
            //{
            //    authToken.Username = userResponse.Username;
            //    authToken.UserId = userResponse.Id;
            //    authToken.Success = true;
            //    authToken.Firstname = userResponse.Firstname;
            //    authToken.Surname = userResponse.Surname;
            //    authToken.RoleDescription = userResponse.RoleDescription;
            //    authToken.VendorId = userResponse.Vendor.Id;
            //    authToken.VendorName = userResponse.Vendor.Name;
            //    authToken.VendorType = userResponse.Vendor.Type;
            //    authToken.Token = _authManager.Authenticate(credentials.Username);
            //}

            return authToken;
        }
    }
}
