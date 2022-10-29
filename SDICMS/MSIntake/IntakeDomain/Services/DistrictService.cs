using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class DistrictService : IDistrictService
    {
        private readonly IMapper _mapper;
        private readonly IDistrictRepository _districtRepository;

        public DistrictService(IMapper mapper,
                            IDistrictRepository districtRepository)
        {
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<DistrictDto> GetDistrictById(int districtId)
        {
            var responseDistrict = await _districtRepository.GetDistrictById(districtId);
            return _mapper.Map<DistrictDto>(responseDistrict);
        }

        public async Task<List<DistrictDto>> GetDistrictByProvinceId(int provinceId)
        {
            var responseDistricts = await _districtRepository.GetDistrictByProvinceId(provinceId);
            return _mapper.Map<List<DistrictDto>>(responseDistricts);
        }
    }
}