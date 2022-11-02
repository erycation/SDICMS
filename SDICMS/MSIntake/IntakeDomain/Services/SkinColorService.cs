using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class SkinColorService : ISkinColorService
    {
        private readonly IMapper _mapper;
        private readonly ISkinColorRepository _skinColorRepository;

        public SkinColorService(IMapper mapper,
                            ISkinColorRepository skinColorRepository)
        {
            _mapper = mapper;
            _skinColorRepository = skinColorRepository;
        }

        public async Task<List<SkinColorDto>> GetAllSkinColors()
        {
            var responseSkinColor = await _skinColorRepository.GetAllSkinColors();
            return _mapper.Map<List<SkinColorDto>>(responseSkinColor);
        }
    }
}
