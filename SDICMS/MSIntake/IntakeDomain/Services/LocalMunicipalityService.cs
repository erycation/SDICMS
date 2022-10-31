using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class LocalMunicipalityService : ILocalMunicipalityService
    {
        private readonly IMapper _mapper;
        private readonly ILocalMunicipalityRepository _localMunicipalityRepository;

        public LocalMunicipalityService(IMapper mapper,
                            ILocalMunicipalityRepository localMunicipalityRepository)
        {
            _mapper = mapper;
            _localMunicipalityRepository = localMunicipalityRepository;
        }

        public async Task<LocalMunicipalityDto> GetLocalMunicipalityById(int localMunicipalityId)
        {
            var responseLocalMunicipality = await _localMunicipalityRepository.GetLocalMunicipalityById(localMunicipalityId);
            return _mapper.Map<LocalMunicipalityDto>(responseLocalMunicipality);
        }

        public async Task<LocalMunicipalityDto> GetLocalMunicipalityByName(int districtId, string description)
        {
            var responseLocalMunicipality = await _localMunicipalityRepository.GetLocalMunicipalityByName(districtId, description);
            return _mapper.Map<LocalMunicipalityDto>(responseLocalMunicipality);
        }

        public async Task<List<LocalMunicipalityDto>> GetLocalMunicipalitiesByDistrictId(int districtId)
        {
            var responseLocalMunicipality = await _localMunicipalityRepository.GetLocalMunicipalitiesByDistrictId(districtId);
            return _mapper.Map<List<LocalMunicipalityDto>>(responseLocalMunicipality);
        }
    }
}