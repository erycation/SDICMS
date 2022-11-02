using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class AddressTypeService : IAddressTypeService
    {
        private readonly IMapper _mapper;
        private readonly IAddressTypeRepository _addressTypeRepository;

        public AddressTypeService(IMapper mapper,
                                  IAddressTypeRepository addressTypeRepository)
        {
            _mapper = mapper;
            _addressTypeRepository = addressTypeRepository;
        }

        public async Task<AddressTypeDto> GetAddressTypeById(int addressTypeId)
        {
            var responseAddressType = await _addressTypeRepository.GetAddressTypeById(addressTypeId);
            return _mapper.Map<AddressTypeDto>(responseAddressType);
        }

        public async Task<List<AddressTypeDto>> GetAddressTypes()
        {
            var responseAddressType = await _addressTypeRepository.GetAddressTypes();
            return _mapper.Map<List<AddressTypeDto>>(responseAddressType);
        }
    }
}