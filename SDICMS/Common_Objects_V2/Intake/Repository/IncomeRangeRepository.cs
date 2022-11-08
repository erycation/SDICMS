using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class IncomeRangeRepository : IntakeRepository<IncomeRange>, IIncomeRangeRepository
    {

        public IncomeRangeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<IncomeRange> GetIncomeRangeById(int incomeRangeId)
        {
            return await _intakeDBContext.IncomeRanges.SingleOrDefaultAsync(i => i.Income_Range_Id == incomeRangeId);
        }

        public async Task<List<IncomeRange>> GetIncomeRanges()
        {
            return await _intakeDBContext.IncomeRanges.ToListAsync();
        }
    }
}