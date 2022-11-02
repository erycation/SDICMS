using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ISchoolRepository
    {
        Task<School> GetSchoolById(int schoolId);
        Task<List<School>> GetAllSchoolByType(int schoolTypeId);
        Task<School> CreateSchool(School school);
        Task<School> UpdateSchool(School school);
    }
}
