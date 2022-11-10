using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class RaceService : IRaceService
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public RaceService(IMapper mapper,
                            IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }

        public async Task<List<RaceDto>> GetAllRaces()
        {
            var responseRace = await _raceRepository.GetAllRaces();
            return _mapper.Map<List<RaceDto>>(responseRace);
        }

        public async Task<RaceDto> GetRaceById(int raceId)
        {
            var responseRace = await _raceRepository.GetRaceById(raceId);
            return _mapper.Map<RaceDto>(responseRace);
        }
    }
}
