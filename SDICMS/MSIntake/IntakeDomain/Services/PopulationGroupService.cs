using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class PopulationGroupService : IPopulationGroupService
    {
        private readonly IMapper _mapper;
        private readonly IPopulationGroupRepository _populationGroupRepository;

        public PopulationGroupService(IMapper mapper,
                                  IPopulationGroupRepository populationGroupRepository)
        {
            _mapper = mapper;
            _populationGroupRepository = populationGroupRepository;
        }

        public async Task<List<PopulationGroupDto>> GetPopulationGroups()
        {
            var responsePopulationGroup = await _populationGroupRepository.GetPopulationGroups();
            return _mapper.Map<List<PopulationGroupDto>>(responsePopulationGroup);
        }

        public async Task<PopulationGroupDto> GetPopulationGroupById(int populationGroupId)
        {
            var responsePopulationGroup = await _populationGroupRepository.GetPopulationGroupById(populationGroupId);
            return _mapper.Map<PopulationGroupDto>(responsePopulationGroup);
        }
    }
}