using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class ContactTypeRepository : IntakeRepository<ContactType>, IContactTypeRepository
    {

        public ContactTypeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<ContactType> GetContactTypeById(int contactTypeId)
        {
            return await _intakeDBContext.ContactTypes.SingleOrDefaultAsync(c => c.Contact_Type_Id == contactTypeId);
        }

        public async Task<List<ContactType>> GetContactTypes()
        {
            return await _intakeDBContext.ContactTypes.ToListAsync();
        }
    }
}