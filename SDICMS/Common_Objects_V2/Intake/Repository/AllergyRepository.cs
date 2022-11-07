using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class AllergyRepository : IntakeRepository<Allergy>, IAllergyRepository
    {

        public AllergyRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Allergy> GetAllergyById(int allergyId)
        {
            return await _intakeDBContext.Allergies.SingleOrDefaultAsync(a => a.Allergy_Id == allergyId);
        }

        public async Task<List<Allergy>> GetAllergies()
        {
            return await _intakeDBContext.Allergies.ToListAsync();
        }
    }
}