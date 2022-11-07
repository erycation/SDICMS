using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class AllergyService : IAllergyService
    {
        private readonly IMapper _mapper;
        private readonly IAllergyRepository _allergyRepository;

        public AllergyService(IMapper mapper,
                                  IAllergyRepository allergyRepository)
        {
            _mapper = mapper;
            _allergyRepository = allergyRepository;
        }

        public async Task<List<AllergyDto>> GetAllergies()
        {
            var responseAllegies = await _allergyRepository.GetAllergies();
            return _mapper.Map<List<AllergyDto>>(responseAllegies);
        }

        public async Task<AllergyDto> GetAllergyById(int allergyId)
        {
            var responseAllegies = await _allergyRepository.GetAllergyById(allergyId);
              return _mapper.Map<AllergyDto>(responseAllegies);
        }
    }
}