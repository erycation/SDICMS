using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class TownService : ITownService
    {
        private readonly IMapper _mapper;
        private readonly ITownRepository _townRepository;

        public TownService(IMapper mapper,
                            ITownRepository townRepository)
        {
            _mapper = mapper;
            _townRepository = townRepository;
        }

        public async Task<TownDto> GetTownById(int townId)
        {
            var responseTown = await _townRepository.GetTownById(townId);
            return _mapper.Map<TownDto>(responseTown);
        }

        public async Task<List<TownDto>> GetTownByLocalMicipalilityId(int localMunicipalityId)
        {
            var responseTowns = await _townRepository.GetTownByLocalMicipalilityId(localMunicipalityId);
            return _mapper.Map<List<TownDto>>(responseTowns);
        }
    }
}