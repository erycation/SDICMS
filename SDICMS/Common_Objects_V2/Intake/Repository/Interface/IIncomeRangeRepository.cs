using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IIncomeRangeRepository
    {
        Task<IncomeRange> GetIncomeRangeById(int incomeRangeId);
        Task<List<IncomeRange>> GetIncomeRanges();
    }
}
