using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IMaritalStatusService
    {
        Task<MaritalStatusDto> GetMaritalStatuById(int maritalStatusId);
        Task<List<MaritalStatusDto>> GetMaritalStatus();
    }
}
