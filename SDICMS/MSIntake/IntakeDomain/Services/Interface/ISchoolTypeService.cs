using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ISchoolTypeService
    {
        Task<SchoolTypeDto> GetSchoolTypeById(int schoolTypeId);
        Task<List<SchoolTypeDto>> GetAllSchoolType();
        Task<SchoolTypeDto> CreateSchoolType(SchoolTypeDto schoolTypeDto);
        Task<SchoolTypeDto> UpdateSchoolType(SchoolTypeDto schoolTypeDto);
    }
}
