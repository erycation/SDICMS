using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IIncomeRangeService
    {
        Task<IncomeRangeDto> GetIncomeRangeById(int incomeRangeId);
        Task<List<IncomeRangeDto>> GetIncomeRanges();
    }
}
