using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class DistrictRepository : IntakeRepository<District>, IDistrictRepository
    {

        public DistrictRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<District> GetDistrictById(int districtId)
        {
            return await _intakeDBContext.Districts.SingleOrDefaultAsync(d => d.District_Id == districtId);
        }

        public async Task<List<District>> GetDistrictByProvinceId(int provinceId)
        {
            return await _intakeDBContext.Districts.Where(d => d.Province_Id == provinceId).ToListAsync();
        }
    }
}
