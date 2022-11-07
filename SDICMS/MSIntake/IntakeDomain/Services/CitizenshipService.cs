using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class CitizenshipService : ICitizenshipService
    {
        private readonly IMapper _mapper;
        private readonly ICitizenshipRepository _citizenshipRepository;

        public CitizenshipService(IMapper mapper,
                                  ICitizenshipRepository citizenshipRepository)
        {
            _mapper = mapper;
            _citizenshipRepository = citizenshipRepository;
        }

        public async Task<CitizenshipDto> GetCitizenshipById(int citizenId)
        {
            var responseCitizen = await _citizenshipRepository.GetCitizenshipById(citizenId);
             return _mapper.Map<CitizenshipDto>(responseCitizen);
        }

        public async Task<List<CitizenshipDto>> GetCitizenships()
        {
            var responseCitizen = await _citizenshipRepository.GetCitizenships();
            return _mapper.Map<List<CitizenshipDto>>(responseCitizen);
        }
    }
}