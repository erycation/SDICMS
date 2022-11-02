using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class GenderService : IGenderService
    {
        private readonly IMapper _mapper;
        private readonly IGenderRepository _genderRepository;

        public GenderService(IMapper mapper,
                            IGenderRepository genderRepository)
        {
            _mapper = mapper;
            _genderRepository = genderRepository;
        }

        public async Task<List<GenderDto>> GetGenders()
        {
            var responseGenders = await _genderRepository.GetGenders();
            return _mapper.Map<List<GenderDto>>(responseGenders);
        }
    }
}
