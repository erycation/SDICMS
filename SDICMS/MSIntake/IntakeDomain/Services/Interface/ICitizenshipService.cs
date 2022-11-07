using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ICitizenshipService
    {
        Task<CitizenshipDto> GetCitizenshipById(int citizenId);
        Task<List<CitizenshipDto>> GetCitizenships();
    }
}
