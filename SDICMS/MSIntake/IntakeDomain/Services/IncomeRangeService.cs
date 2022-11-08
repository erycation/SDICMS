using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class IncomeRangeService : IIncomeRangeService
    {
        private readonly IMapper _mapper;
        private readonly IIncomeRangeRepository _incomeRangeRepository;

        public IncomeRangeService(IMapper mapper,
                                  IIncomeRangeRepository incomeRangeRepository)
        {
            _mapper = mapper;
            _incomeRangeRepository = incomeRangeRepository;
        }

        public async Task<List<IncomeRangeDto>> GetIncomeRanges()
        {
            var responseContactType = await _incomeRangeRepository.GetIncomeRanges();
            return _mapper.Map<List<IncomeRangeDto>>(responseContactType);
        }

        public async Task<IncomeRangeDto> GetIncomeRangeById(int incomeRangeId)
        {
            var responseContactType = await _incomeRangeRepository.GetIncomeRangeById(incomeRangeId);
            return _mapper.Map<IncomeRangeDto>(responseContactType);
        }
    }
}