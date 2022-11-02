

using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class SchoolRepository : IntakeRepository<School>, ISchoolRepository
    {

        public SchoolRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<School> CreateSchool(School school)
        {
            await _intakeDBContext.Schools.AddAsync(school);
            await _intakeDBContext.SaveChangesAsync();
            return school;
        }

        public async Task<List<School>> GetAllSchoolByType(int schoolTypeId)
        {
            return await _intakeDBContext.Schools.Where(s => s.School_Type_Id == schoolTypeId).ToListAsync();
        }

        public async Task<School> GetSchoolById(int schoolId)
        {
            return await _intakeDBContext.Schools.SingleOrDefaultAsync(s => s.School_Id == schoolId);
        }

        public async Task<School> UpdateSchool(School school)
        {
            _intakeDBContext.Schools.Update(school);
            await _intakeDBContext.SaveChangesAsync();
            return school;
        }
    }
}