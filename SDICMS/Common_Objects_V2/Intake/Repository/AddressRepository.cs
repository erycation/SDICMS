using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class AddressRepository : IntakeRepository<Address>, IAddressRepository
    {

        public AddressRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Address> CreateAddress(Address address)
        {
            await _intakeDBContext.Addresses.AddAsync(address);
            await _intakeDBContext.SaveChangesAsync();
            return address;
        }

        public async Task<Address> GetAddressById(int addressId)
        {
            return await _intakeDBContext.Addresses.SingleOrDefaultAsync(a => a.Address_Id == addressId);
        }

        public async Task<List<Address>> GetAddressByType(int addressTypeId, string name)
        {
            return await _intakeDBContext.Addresses.Where(a => a.Address_Type_Id == addressTypeId && a.Address_Line_1.Contains(name) || a.Address_Line_2.Contains(name)).ToListAsync();
        }

        public async Task<Address> UpdateAddress(Address address)
        {
            _intakeDBContext.Addresses.Update(address);
            await _intakeDBContext.SaveChangesAsync();
            return address;
        }
    }
}
