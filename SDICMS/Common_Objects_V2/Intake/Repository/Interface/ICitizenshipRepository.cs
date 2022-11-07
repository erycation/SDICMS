using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ICitizenshipRepository
    {
        Task<Citizenship> GetCitizenshipById(int citizenId);
        Task<List<Citizenship>> GetCitizenships();
    }
}
