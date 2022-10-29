using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GroupService(IMapper mapper,
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
    }
}
