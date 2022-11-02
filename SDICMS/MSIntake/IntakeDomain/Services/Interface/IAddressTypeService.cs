using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IAddressTypeService
    {
        Task<AddressTypeDto> GetAddressTypeById(int addressTypeId);
        Task<List<AddressTypeDto>> GetAddressTypes();
    }
}
