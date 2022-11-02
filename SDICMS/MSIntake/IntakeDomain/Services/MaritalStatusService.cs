using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class MaritalStatusService : IMaritalStatusService
    {
        private readonly IMapper _mapper;
        private readonly IMaritalStatusRepository _maritalStatusRepository;

        public MaritalStatusService(IMapper mapper,
                            IMaritalStatusRepository maritalStatusRepository)
        {
            _mapper = mapper;
            _maritalStatusRepository = maritalStatusRepository;
        }

        public async Task<MaritalStatusDto> GetMaritalStatuById(int maritalStatusId)
        {
            var responseMaritalStatus = await _maritalStatusRepository.GetMaritalStatuById(maritalStatusId);
            return _mapper.Map<MaritalStatusDto>(responseMaritalStatus);
        }

        public async Task<List<MaritalStatusDto>> GetMaritalStatus()
        {
            var responseMaritalStatus = await _maritalStatusRepository.GetMaritalStatus();
            return _mapper.Map<List<MaritalStatusDto>>(responseMaritalStatus);
        }
    }
}