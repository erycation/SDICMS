using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class DisabilityTypeRepository : IntakeRepository<DisabilityType>, IDisabilityTypeRepository
    {

        public DisabilityTypeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<DisabilityType> GetDisabilityTypeById(int disabilityTypeId)
        {
            return await _intakeDBContext.DisabilityTypes.SingleOrDefaultAsync(d => d.DisabilityType_Id == disabilityTypeId);
        }

        public async Task<List<DisabilityType>> GetDisabilityTypes()
        {
            return await _intakeDBContext.DisabilityTypes.ToListAsync();
        }

        public async Task<List<DisabilityType>> GetDisabilityTypeByDisabilityId(int disabilityId)
        {
            return await _intakeDBContext.DisabilityTypes.Where(d => d.Disability.Disability_Id == disabilityId).ToListAsync();
        }
    }
}