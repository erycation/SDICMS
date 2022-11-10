using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IReligionRepository
    {
        Task<List<Religion>> GetAllReligions();
        Task<Religion> GetReligionById(int religionId);
    }
}
