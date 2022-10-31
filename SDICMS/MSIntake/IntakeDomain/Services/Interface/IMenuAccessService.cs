using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IMenuAccessService
    {
        Task<MenuAccessDto> CreateMenuAccess(RegisterMenuAccess registerMenuAccess);
    }
}
