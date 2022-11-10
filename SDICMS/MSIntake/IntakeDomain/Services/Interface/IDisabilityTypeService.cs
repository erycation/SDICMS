using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IDisabilityTypeService
    {
        Task<DisabilityTypeDto> GetDisabilityTypeById(int disabilityTypeId);
        Task<List<DisabilityTypeDto>> GetDisabilityTypes();
        Task<List<DisabilityTypeDto>> GetDisabilityTypeByDisabilityId(int disabilityId);
    }
}
