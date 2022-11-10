using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IDeceaseRepository
    {
        Task<Decease> GetDeceaseById(int deceaseId);
        Task<List<Decease>> GetDeceases();
    }
}
