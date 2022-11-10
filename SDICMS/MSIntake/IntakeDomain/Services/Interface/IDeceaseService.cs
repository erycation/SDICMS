using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IDeceaseService
    {
        Task<DeceaseDto> GetDeceaseById(int deceaseId);
        Task<List<DeceaseDto>> GetDeceases();
    }
}
