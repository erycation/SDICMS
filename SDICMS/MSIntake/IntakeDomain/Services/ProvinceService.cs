using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IMapper _mapper;
        private readonly IProvinceRepository _provinceRepository;

        public ProvinceService(IMapper mapper,
                            IProvinceRepository provinceRepository)
        {
            _mapper = mapper;
            _provinceRepository = provinceRepository;
        }

        public async Task<ProvinceDto> GetProvinceById(int provinceId)
        {
            var responseProvince = await _provinceRepository.GetProvinceById(provinceId);
            return _mapper.Map<ProvinceDto>(responseProvince);
        }

        public async Task<List<ProvinceDto>> GetProvincesByCountryId(int countryId)
        {
            var responseProvinces = await _provinceRepository.GetProvincesByCountryId(countryId);
            return _mapper.Map<List<ProvinceDto>>(responseProvinces);
        }
    }
}
