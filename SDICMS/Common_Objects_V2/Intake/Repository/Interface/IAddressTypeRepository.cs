using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IAddressTypeRepository
    {
        Task<AddressType> GetAddressTypeById(int addressTypeId);
        Task<List<AddressType>> GetAddressTypes();
    }
}
