using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IAddressRepository
    {
        Task<Address> GetAddressById(int addressId);
        Task<List<Address>> GetAddressByType(int addressTypeId, string name);
        Task<Address> CreateAddress(Address address);
        Task<Address> UpdateAddress(Address address);
    }
}
