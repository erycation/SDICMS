using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IGenderService
    {
        Task<List<GenderDto>> GetGenders();
        Task<GenderDto> GetGenderById(int genderId);
    }
}
