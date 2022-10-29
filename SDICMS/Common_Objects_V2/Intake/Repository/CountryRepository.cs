using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class CountryRepository : IntakeRepository<Country>, ICountryRepository
    {

        public CountryRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _intakeDBContext.Countries.SingleOrDefaultAsync(c => c.Country_Id == countryId);
        }

        public async Task<List<Country>> GetListOfCountries()
        {
            return await _intakeDBContext.Countries.ToListAsync();
        }
    }
}