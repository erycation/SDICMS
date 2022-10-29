using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class ProvinceRepository : IntakeRepository<Province>, IProvinceRepository
    {

        public ProvinceRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Province> GetProvinceById(int provinceId)
        {
            return await _intakeDBContext.Provinces.SingleOrDefaultAsync(p => p.Province_Id == provinceId);
        }

        public async Task<List<Province>> GetProvincesByCountryId(int countryId)
        {
            return await _intakeDBContext.Provinces.Where(p => p.Country_Id == countryId).ToListAsync();
        }
    }
}
