using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class DisabilityTypeService : IDisabilityTypeService
    {
        private readonly IMapper _mapper;
        private readonly IDisabilityTypeRepository _disabilityTypeRepository;

        public DisabilityTypeService(IMapper mapper,
                                  IDisabilityTypeRepository disabilityTypeRepository)
        {
            _mapper = mapper;
            _disabilityTypeRepository = disabilityTypeRepository;
        }

        public async Task<List<DisabilityTypeDto>> GetDisabilityTypes()
        {
            var responseDisabilityType = await _disabilityTypeRepository.GetDisabilityTypes();
            return _mapper.Map<List<DisabilityTypeDto>>(responseDisabilityType);
        }

        public async Task<DisabilityTypeDto> GetDisabilityTypeById(int disabilityTypeId)
        {
            var responseDisabilityType = await _disabilityTypeRepository.GetDisabilityTypeById(disabilityTypeId);
            return _mapper.Map<DisabilityTypeDto>(responseDisabilityType);
        }

        public async Task<List<DisabilityTypeDto>> GetDisabilityTypeByDisabilityId(int disabilityId)
        {
            var responseDisabilityType = await _disabilityTypeRepository.GetDisabilityTypeByDisabilityId(disabilityId);
            return _mapper.Map<List<DisabilityTypeDto>>(responseDisabilityType);
        }

    }
}