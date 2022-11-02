using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ISchoolTypeRepository
    {
        Task<SchoolType> GetSchoolTypeById(int schoolTypeId);
        Task<List<SchoolType>> GetAllSchoolType();
        Task<SchoolType> CreateSchoolType(SchoolType schoolType);
        Task<SchoolType> UpdateSchoolType(SchoolType schoolType);
    }
}
