using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ISchoolService
    {
        Task<SchoolDto> GetSchoolById(int schoolId);
        Task<List<SchoolDto>> GetAllSchoolByType(int schoolTypeId);
        Task<SchoolDto> CreateSchool(SchoolDto schoolDto);
        Task<SchoolDto> UpdateSchool(SchoolDto schoolDto);
    }
}
