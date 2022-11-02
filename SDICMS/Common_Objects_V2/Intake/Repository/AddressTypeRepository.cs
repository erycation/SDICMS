using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class AddressTypeRepository : IntakeRepository<AddressType>, IAddressTypeRepository
    {

        public AddressTypeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<AddressType> GetAddressTypeById(int addressTypeId)
        {
            return await _intakeDBContext.AddressTypes.SingleOrDefaultAsync(a => a.Address_Type_Id == addressTypeId);
        }

        public async Task<List<AddressType>> GetAddressTypes()
        {
            return await _intakeDBContext.AddressTypes.ToListAsync();
        }
    }
}
