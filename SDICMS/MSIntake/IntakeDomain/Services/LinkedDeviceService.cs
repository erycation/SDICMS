using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class LinkedDeviceService : ILinkedDeviceService
    {
        private readonly IMapper _mapper;
        private readonly ILinkedDeviceRepository _linkedDeviceRepository;

        public LinkedDeviceService(IMapper mapper,
                                ILinkedDeviceRepository linkedDeviceRepository)
        {
            _mapper = mapper;
            _linkedDeviceRepository = linkedDeviceRepository;
        }

        public async Task<LinkedDeviceDto> CreateLinkDevice(LinkedDeviceDto linkedDeviceDto)
        {
            var requestLinkDevice = new LinkedDevice
            {
                UserId = linkedDeviceDto.UserId,
                DeviceId = linkedDeviceDto.DeviceId,
                Name = linkedDeviceDto.Name
            };

            var responseLinkedDevice = await _linkedDeviceRepository.CreateLinkDevice(requestLinkDevice);
            return _mapper.Map<LinkedDeviceDto>(responseLinkedDevice);
        }

        public async Task<LinkedDeviceDto> GetActiveLinkedDeviceByDeviceId(string deviceId)
        {
            var responseLinkedDevice = await _linkedDeviceRepository.GetActiveLinkedDeviceByDeviceId(deviceId);
            return _mapper.Map<LinkedDeviceDto>(responseLinkedDevice);
        }

        public async Task<LinkedDeviceDto> GetDeviceByDeviceId(string deviceId)
        {
            var responseLinkedDevice = await _linkedDeviceRepository.GetDeviceByDeviceId(deviceId);
            return _mapper.Map<LinkedDeviceDto>(responseLinkedDevice);
        }

        public async Task<LinkedDeviceDto> UpdateLinkedDevice(LinkedDeviceDto linkedDeviceDto)
        {
            throw new NotImplementedException();
        }

        //public Task<List<LinkedDeviceDto>> GetLinkedDevicesByUserId(int userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<AddressDto> UpdateAddress(AddressDto addressDto)
        //{
        //    if (addressDto.Address_Type_Id == null)
        //        throw new AppException($"Address type is required.");

        //    if (_addressTypeService.GetAddressTypeById((int)addressDto.Address_Type_Id) == null)
        //        throw new AppException($"Address type not found.");

        //    var responseAddress = await _addressRepository.GetAddressById(addressDto.Address_Id);
        //    if (responseAddress == null)
        //        throw new AppException($"School {addressDto.Address_Type_Id} not found.");

        //    responseAddress.Address_Type_Id = addressDto.Address_Type_Id;
        //    responseAddress.Address_Line_2 = addressDto.Address_Line_2;
        //    responseAddress.Address_Line_1 = addressDto.Address_Line_1;
        //    responseAddress.Town_Id = addressDto.Town_Id;

        //    var responseUpdatedAddress = await _addressRepository.UpdateAddress(responseAddress);
        //    return _mapper.Map<AddressDto>(responseUpdatedAddress);
        //}


    }
}