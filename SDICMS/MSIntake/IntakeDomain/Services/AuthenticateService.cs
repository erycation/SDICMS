using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;

namespace MSIntake.IntakeDomain.Services
{
    public class AuthenticateService : IAuthenticateService
    {

        private readonly IUsersService _userService;
        private readonly IAuthManager _authManager;
        private readonly IMenuAccessService _menuAccessService;
        
        public AuthenticateService(IUsersService userService,
                                     IAuthManager authManager,
                                     IMenuAccessService menuAccessService)
        {
            _userService = userService;
            _authManager = authManager;
            _menuAccessService = menuAccessService;
        }

        public async Task<AuthToken> Login(Credentials credentials)
        {
            List<int> roleIds;
            var authToken = new AuthToken();
            var userResponse = await _userService.AuthenticateUser(credentials);

            authToken.Username = userResponse.User_Name;
            authToken.UserId = userResponse.User_Id;
            authToken.Success = true;
            authToken.Firstname = userResponse.First_Name;
            authToken.Surname = userResponse.Last_Name;
            authToken.Token = _authManager.Authenticate(credentials.Username);
            authToken.UserRoleDtos = userResponse.UserRoleDtos;

            roleIds = userResponse.UserRoleDtos.Select(r => r.Role_Id).ToList();

            authToken.MenuAccessDtos = await _menuAccessService.GetMenuAccessByRolesId(roleIds);

            return authToken;
        }

        public async Task<AuthToken> MobileLogin(MobileCredentials mobileCredentials)
        {

            var authToken = new AuthToken();
            var userResponse = await _userService.MobileAuthenticate(mobileCredentials);

            authToken.Username = userResponse.User_Name;
            authToken.UserId = userResponse.User_Id;
            authToken.Success = true;
            authToken.Firstname = userResponse.First_Name;
            authToken.Surname = userResponse.Last_Name;
            authToken.Token = _authManager.Authenticate(mobileCredentials.Username);
     
            return authToken;
        }

        public async Task<AuthToken> LoginToLinkDevice(LinkUserToMobile linkUserToMobile)
        {
            List<int> roleIds;
            var authToken = new AuthToken();
            //Task<UserDto> LoginToLinkDevice(LinkUserToMobile linkUserToMobile)
            var userResponse = await _userService.LoginToLinkDevice(linkUserToMobile);

            authToken.Username = userResponse.User_Name;
            authToken.UserId = userResponse.User_Id;
            authToken.Success = true;
            authToken.Firstname = userResponse.First_Name;
            authToken.Surname = userResponse.Last_Name;
            authToken.Token = _authManager.Authenticate(linkUserToMobile.Username);
            authToken.UserRoleDtos = userResponse.UserRoleDtos;

            return authToken;

        }
        #region PrivcateMethod

        private List<MenuAccessDto> GetMenus(List<MenuAccessDto> menus)
        {
            var menuAccessDtos = new List<MenuAccessDto>();
            var menuModules = menus.Where(m => m.IsModule).ToList();

            foreach(var module in menuModules)
            {
                menuAccessDtos.Add(module);

            }

            return menuAccessDtos;

        }

        #endregion
    }
}

