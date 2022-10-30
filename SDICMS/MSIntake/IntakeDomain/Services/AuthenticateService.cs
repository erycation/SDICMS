using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;

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
            var userResponse = await _userService.AuthenticateUser(credentials);

            authToken.Username = userResponse.User_Name;
            authToken.UserId = userResponse.User_Id;
            authToken.Success = true;
            authToken.Firstname = userResponse.First_Name;
            authToken.Surname = userResponse.Last_Name;
            authToken.Token = _authManager.Authenticate(credentials.Username);
            authToken.UserRoleDtos = userResponse.UserRoleDtos;

            return authToken;
        }
    }
}

