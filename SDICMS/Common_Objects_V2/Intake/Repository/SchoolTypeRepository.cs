

using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class SchoolTypeRepository : IntakeRepository<SchoolType>, ISchoolTypeRepository
    {

        public SchoolTypeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<SchoolType> CreateSchoolType(SchoolType schoolType)
        {
            await _intakeDBContext.SchoolTypes.AddAsync(schoolType);
            await _intakeDBContext.SaveChangesAsync();
            return schoolType;
        }

        public async Task<List<SchoolType>> GetAllSchoolType()
        {
            return await _intakeDBContext.SchoolTypes.ToListAsync();
        }

        public async Task<SchoolType> GetSchoolTypeById(int schoolTypeId)
        {
            return await _intakeDBContext.SchoolTypes.SingleOrDefaultAsync(s => s.School_Type_Id == schoolTypeId);
        }

        public async Task<SchoolType> UpdateSchoolType(SchoolType schoolType)
        {
            _intakeDBContext.SchoolTypes.Update(schoolType);
            await _intakeDBContext.SaveChangesAsync();
            return schoolType;
        }
    }
}