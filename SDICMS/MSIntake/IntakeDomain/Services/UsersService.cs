using BCryptNet = BCrypt.Net.BCrypt;
using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.Shared.Enum;
using MSIntake.IntakeDomain.Model.Response;

namespace MSIntake.IntakeDomain.Services
{
    public class UsersService : IUsersService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly ILinkedDeviceService _linkedDeviceService;

        public UsersService(IMapper mapper,
                            IUserRepository userRepository,
                            ILinkedDeviceService linkedDeviceService)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _linkedDeviceService = linkedDeviceService;
        }

        public async Task<UserDto> GetUserDetailsByUsername(string username)
        {
            var responseUser = await _userRepository.GetUserDetailsByUsername(username);
            return _mapper.Map<UserDto>(responseUser);
        }

        public async Task<UserDto> GetUserDetailsById(int userId)
        {
            var responseUser = await _userRepository.GetUserDetailsById(userId);
            return _mapper.Map<UserDto>(responseUser);
        }

        //public async Task<MobileResponse> GetUserDetailsByDeviceId(string deviceId)
        //{
        //    var responseUser = await _userRepository.GetUserDetailsByDeviceId(deviceId);
        //    return _mapper.Map<MobileResponse>(responseUser);
        //}

        public async Task<UserDto> CreateUser(RegisterUser registerUser)
        {
            var responseUserExist = await _userRepository.GetUserDetailsByUsername(registerUser.User_Name);
            if (responseUserExist == null)
                throw new AppException($"Username {responseUserExist.User_Name} exist.");

            if (registerUser.Password != registerUser.ConfirmPassword)
                throw new AppException($"Confirm password not match.");

            var requestUser = new User {
                First_Name = registerUser.First_Name,
                Last_Name = registerUser.Last_Name,
                Initials = registerUser.Initials,
                Email_Address = registerUser.Email_Address,
                User_Name = registerUser.User_Name,
                PasswordHash = BCryptNet.HashPassword(registerUser.Password),
                Date_Last_Login = registerUser.Date_Last_Login,
                Created_By = registerUser.Created_By,
                Date_Last_Modified = registerUser.Date_Last_Modified,
                Modified_By = registerUser.Modified_By,
                AccountStatus = AccountStatus.Open.ToString()

            };

            var responseUser = await _userRepository.CreateUser(requestUser);
            if (responseUser == null)
                throw new AppException($"Error creating user.");
            return _mapper.Map<UserDto>(responseUser);
        }

        public async Task<UserDto> ActivateUser(UserDto userDto)
        {
            var responseUser = await _userRepository.GetUserDetailsById(userDto.User_Id);
            if (responseUser == null)
                throw new AppException($"Username {userDto.User_Name} not found.");
            responseUser.Is_Active = true;
            responseUser.Is_Deleted = false;
            var responseUpdatedRole = await _userRepository.UpdateUser(responseUser);
            return _mapper.Map<UserDto>(responseUpdatedRole);
        }

        public async Task<UserDto> AuthenticateUser(Credentials credentials)
        {
            var userResponse = await _userRepository.GetUserDetailsByUsername(credentials.Username);

            if (userResponse == null)
                throw new AppException($"Username {credentials.Username} not found.");

            if (userResponse.Tries > 3)
                throw new AppException($"User account is locked.");

            if (!userResponse.Is_Active || userResponse.Is_Deleted)
                throw new AppException($"User not active.");

            if (!BCryptNet.Verify(credentials.Password, userResponse.PasswordHash))
                throw new AppException($"Incorrect password.{UserTriesLoginCount(userResponse)} attempts remaining.");

            return _mapper.Map<UserDto>(userResponse);
        }

        public async Task<UserDto> MobileAuthenticate(MobileCredentials mobileCredentials)
        {
            var userResponse = await _userRepository.GetUserDetailsByUsername(mobileCredentials.Username);

            if (userResponse == null)
                throw new AppException($"Username {mobileCredentials.Username} not found.");

            if (userResponse.Tries > 3)
                throw new AppException($"User account is locked.");

            if (!userResponse.Is_Active || userResponse.Is_Deleted)
                throw new AppException($"User not active.");
 
            if (!BCryptNet.Verify(mobileCredentials.Password, userResponse.PasswordHash))
                throw new AppException($"Incorrect password.{UserTriesLoginCount(userResponse)} attempts remaining.");

            var deviceStatusResponse = await _linkedDeviceService.GetDeviceByDeviceId(mobileCredentials.DeviceId);
            if (!deviceStatusResponse.Active)
                throw new AppException($"Device linked not active.");

            return _mapper.Map<UserDto>(userResponse);
        }

        public async Task<UserDto> LoginToLinkDevice(LinkUserToMobile linkUserToMobile)
        {
            var userResponse = await _userRepository.GetUserDetailsByUsername(linkUserToMobile.Username);

            if (userResponse == null)
                throw new AppException($"Username {linkUserToMobile.Username} not found.");

            if (userResponse.Tries > 3)
                throw new AppException($"User account is locked.");

            if (!userResponse.Is_Active || userResponse.Is_Deleted)
                throw new AppException($"User not active.");


            var linkedDeviceDto = new LinkedDeviceDto
            {
                UserId = userResponse.User_Id,
                DeviceId = linkUserToMobile.DeviceId,
                Name = linkUserToMobile.DeviceName
            };

            await _linkedDeviceService.CreateLinkDevice(linkedDeviceDto);

            return _mapper.Map<UserDto>(userResponse);
        }

        public async Task<UserDto> ResetPassword(ChangePassword changePassword)
        {
            if (changePassword.Password != changePassword.ConfirmPassword)
                throw new AppException($"Confirm password not match.");

            var responseUser = await _userRepository.GetUserDetailsById(changePassword.UserId);
            if (responseUser == null)
                throw new AppException($"Username not found.");

            responseUser.PasswordExpiryDate = DateTime.Now.AddMonths(12);
            responseUser.Tries = 0;
            responseUser.AccountStatus = AccountStatus.Open.ToString();
            responseUser.PasswordHash = BCryptNet.HashPassword(changePassword.Password);

            var responseUpdatedRole = await _userRepository.UpdateUser(responseUser);
            return _mapper.Map<UserDto>(responseUpdatedRole);
        }

        public async Task<UserDto> DeleteUser(UserDto userDto)
        {
            var responseUser = await _userRepository.GetUserDetailsById(userDto.User_Id);
            if (responseUser == null)
                throw new AppException($"Username {userDto.User_Name} not found.");
            responseUser.Is_Active = false;
            responseUser.Is_Deleted = true;
            var responseUpdatedRole = await _userRepository.UpdateUser(responseUser);
            return _mapper.Map<UserDto>(responseUpdatedRole);
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var userResults = await _userRepository.GetAllUsers();
            return _mapper.Map<List<UserDto>>(userResults);
        }

        public async Task<UserDto> UpdateUser(UserDto userDto)
        {
            var responseUser = await _userRepository.GetUserDetailsById(userDto.User_Id);
            if (responseUser == null)
                throw new AppException($"Username {userDto.User_Name} not found.");

            responseUser.First_Name = userDto.First_Name;
            responseUser.Last_Name = userDto.Last_Name;
            var responseUpdatedRole = await _userRepository.UpdateUser(responseUser);
            return _mapper.Map<UserDto>(responseUpdatedRole);
        }

        public async Task<List<ProbationOfficerDto>> GetProbationOfficersBySupervisorId(int supervisorId)
        {
            var probationOfficerResults = await _userRepository.GetProbationOfficersBySupervisorId(supervisorId);
            return _mapper.Map<List<ProbationOfficerDto>>(probationOfficerResults);
        }

        #region Private_Methods

        private int UserTriesLoginCount(User user)
        {
            int numberOfTries = 4;
            user.Tries = user.Tries + 1;
            user.AccountStatus = numberOfTries == user.Tries ? AccountStatus.Closed.ToString() : AccountStatus.Open.ToString();
            _userRepository.UpdateUser(user);
            return (numberOfTries - (int)user.Tries);
        }

        #endregion
    }
}
