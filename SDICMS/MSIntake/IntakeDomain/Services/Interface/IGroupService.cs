using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IGroupService
    {
        Task<UserDto> GetUserDetailsByUsername(string username);
    }
}
