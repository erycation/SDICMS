using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IDisabilityTypeRepository
    {
        Task<DisabilityType> GetDisabilityTypeById(int disabilityTypeId);
        Task<List<DisabilityType>> GetDisabilityTypes();
        Task<List<DisabilityType>> GetDisabilityTypeByDisabilityId(int disabilityId);        
    }
}
