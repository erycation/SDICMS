using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IAllergyRepository
    {
        Task<Allergy> GetAllergyById(int allergyId);
        Task<List<Allergy>> GetAllergies();
    }
}
