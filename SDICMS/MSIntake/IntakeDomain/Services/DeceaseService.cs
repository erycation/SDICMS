using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class DeceaseService : IDeceaseService
    {
        private readonly IMapper _mapper;
        private readonly IDeceaseRepository _deceaseRepository;

        public DeceaseService(IMapper mapper,
                              IDeceaseRepository deceaseRepository)
        {
            _mapper = mapper;
            _deceaseRepository = deceaseRepository;
        }

        public async Task<List<DeceaseDto>> GetDeceases()
        {
            var responseDecease = await _deceaseRepository.GetDeceases();
            return _mapper.Map<List<DeceaseDto>>(responseDecease);
        }

        public async Task<DeceaseDto> GetDeceaseById(int deseaseId)
        {
            var responseDecease = await _deceaseRepository.GetDeceaseById(deseaseId);
            return _mapper.Map<DeceaseDto>(responseDecease);
        }
    }
}