using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IReligionService
    {
        Task<List<ReligionDto>> GetAllReligions();
        Task<ReligionDto> GetReligionById(int religionId);
    }
}
