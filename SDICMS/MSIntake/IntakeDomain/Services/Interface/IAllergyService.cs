using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IAllergyService
    {
        Task<AllergyDto> GetAllergyById(int allergyId);
        Task<List<AllergyDto>> GetAllergies();
    }
}
