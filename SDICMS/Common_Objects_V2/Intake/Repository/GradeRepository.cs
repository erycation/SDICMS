using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class GradeRepository : IntakeRepository<Grade>, IGradeRepository
    {

        public GradeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<List<Grade>> GetAllGrades()
        {
            return await _intakeDBContext.Grades.ToListAsync();
        }
    }
}