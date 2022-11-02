using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IMaritalStatusRepository
    {
        Task<MaritalStatus> GetMaritalStatuById(int maritalStatusId);
        Task<List<MaritalStatus>> GetMaritalStatus();
    }
}
