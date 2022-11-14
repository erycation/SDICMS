using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class GenderRepository : IntakeRepository<Gender>, IGenderRepository
    {

        public GenderRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<List<Gender>> GetGenders()
        {
            return await _intakeDBContext.Genders.ToListAsync();
        }

        public async Task<Gender> GetGenderById(int genderId)
        {
            return await _intakeDBContext.Genders.SingleOrDefaultAsync(g => g.Gender_Id == genderId);
        }
    }
}