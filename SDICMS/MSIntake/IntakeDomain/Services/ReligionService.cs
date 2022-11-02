using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class ReligionService : IReligionService
    {
        private readonly IMapper _mapper;
        private readonly IReligionRepository _religionRepository;

        public ReligionService(IMapper mapper,
                            IReligionRepository religionRepository)
        {
            _mapper = mapper;
            _religionRepository = religionRepository;
        }

        public async Task<List<ReligionDto>> GetAllReligions()
        {
            var responseReligion = await _religionRepository.GetAllReligions();
            return _mapper.Map<List<ReligionDto>>(responseReligion);
        }
    }
}