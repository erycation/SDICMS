using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class DisabilityService : IDisabilityService
    {
        private readonly IMapper _mapper;
        private readonly IDisabilityRepository _disabilityRepository;

        public DisabilityService(IMapper mapper,
                                  IDisabilityRepository disabilityRepository)
        {
            _mapper = mapper;
            _disabilityRepository = disabilityRepository;
        }

        public async Task<List<DisabilityDto>> GetDisabilities()
        {
            var responseDisability= await _disabilityRepository.GetDisabilities();
            return _mapper.Map<List<DisabilityDto>>(responseDisability);
        }

        public async Task<DisabilityDto> GetDisabilityById(int disabilityId)
        {
            var responseDisability = await _disabilityRepository.GetDisabilityById(disabilityId);
            return _mapper.Map<DisabilityDto>(responseDisability);
        }
    }
}