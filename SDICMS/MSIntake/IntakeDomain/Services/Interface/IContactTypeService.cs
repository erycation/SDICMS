using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IContactTypeService
    {
        Task<ContactTypeDto> GetContactTypeById(int contactTypeId);
        Task<List<ContactTypeDto>> GetContactTypes();
    }
}
