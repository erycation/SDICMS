using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IAddressService
    {
        Task<AddressDto> GetAddressById(int addressId);
        Task<List<AddressDto>> GetAddressByType(int addressTypeId, string name);
        Task<AddressDto> CreateAddress(AddressDto addressDto);
        Task<AddressDto> UpdateAddress(AddressDto addressDto);
    }
}
