using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IDisabilityService
    {
        Task<DisabilityDto> GetDisabilityById(int disabilityId);
        Task<List<DisabilityDto>> GetDisabilities();
    }
}
