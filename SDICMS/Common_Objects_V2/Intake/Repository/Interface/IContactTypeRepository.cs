using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IContactTypeRepository
    {
        Task<ContactType> GetContactTypeById(int contactTypeId);
        Task<List<ContactType>> GetContactTypes();
    }
}