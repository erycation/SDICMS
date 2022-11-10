using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IDisabilityRepository
    {
        Task<Disability> GetDisabilityById(int disabilityId);
        Task<List<Disability>> GetDisabilities();
    }
}
