using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class AddressService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;
        private readonly IAddressTypeService _addressTypeService;

        public AddressService(IMapper mapper,
                                IAddressRepository addressRepository,
                                IAddressTypeService addressTypeService)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
            _addressTypeService = addressTypeService;
        }

        public async Task<AddressDto> CreateAddress(AddressDto addressDto)
        {
            if (addressDto.Address_Type_Id == null)
                throw new AppException($"Address type is required.");

            if (_addressTypeService.GetAddressTypeById((int)addressDto.Address_Type_Id) == null)
                throw new AppException($"Address type not found.");

            var requestAddress = new Address
            {
                Address_Type_Id = addressDto.Address_Type_Id,
                Address_Line_1 = addressDto.Address_Line_1,
                Address_Line_2 = addressDto.Address_Line_2,
                Town_Id = addressDto.Town_Id,
                Postal_Code = addressDto.Postal_Code

            };

            var responseAddress = await _addressRepository.CreateAddress(requestAddress);
            if (responseAddress == null)
                throw new AppException($"Error creating address.");
            return _mapper.Map<AddressDto>(responseAddress);
        }

        public async Task<AddressDto> GetAddressById(int addressId)
        {
            var responseAddress = await _addressRepository.GetAddressById(addressId);
            return _mapper.Map<AddressDto>(responseAddress);
        }

        public async Task<List<AddressDto>> GetAddressByType(int addressTypeId, string name)
        {
            if (name.Length < 5)
                throw new AppException($"Name must be greater than 4 charector.");

            var responseAddress = await _addressRepository.GetAddressByType(addressTypeId, name);
            return _mapper.Map<List<AddressDto>>(responseAddress.Take(100));
        }

        public async Task<AddressDto> UpdateAddress(AddressDto addressDto)
        {
            if (addressDto.Address_Type_Id == null)
                throw new AppException($"Address type is required.");

            if (_addressTypeService.GetAddressTypeById((int)addressDto.Address_Type_Id) == null)
                throw new AppException($"Address type not found.");

            var responseAddress = await _addressRepository.GetAddressById(addressDto.Address_Id);
            if (responseAddress == null)
                throw new AppException($"School {addressDto.Address_Type_Id} not found.");

            responseAddress.Address_Type_Id = addressDto.Address_Type_Id;
            responseAddress.Address_Line_2 = addressDto.Address_Line_2;
            responseAddress.Address_Line_1 = addressDto.Address_Line_1;
            responseAddress.Town_Id = addressDto.Town_Id;

            var responseUpdatedAddress = await _addressRepository.UpdateAddress(responseAddress);
            return _mapper.Map<AddressDto>(responseUpdatedAddress);
        }

    }
}