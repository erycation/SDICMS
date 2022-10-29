using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class UsersService : IUsersService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UsersService(IMapper mapper,
                            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
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

        public async Task<UserDto> CreateUser(UserDto userDto)
        {
            var responseUserExist = await _userRepository.GetUserDetailsByUsername(userDto.User_Name);
            if (responseUserExist == null)
                throw new AppException($"Username {responseUserExist.User_Name} exist.");

            var requestUser = new User {
                First_Name = userDto.First_Name,
                Last_Name = userDto.Last_Name,
                Initials = userDto.Initials,
                Email_Address = userDto.Email_Address,
                User_Name = userDto.User_Name,
                //Password = userDto.Password,
                Date_Last_Login = userDto.Date_Last_Login,
                Created_By = userDto.Created_By,
                Date_Last_Modified = userDto.Date_Last_Modified,
                Modified_By = userDto.Modified_By,
                AccountStatus = userDto.AccountStatus
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

        public Task<UserDto> ChangePassword(UserDto userDto)
        {
            throw new NotImplementedException();
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
    }
}
