using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IDepartmentService
    {
        Task<List<DepartmentDto>> GetDepartments();
        Task<DepartmentDto> GetDepartmentById(int departmentId);
    }
}
