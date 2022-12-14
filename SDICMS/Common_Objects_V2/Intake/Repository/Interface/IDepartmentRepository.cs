using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IDepartmentRepository
    {
        Task<Department> GetDepartmentById(int departmentId);
        Task<List<Department>> GetDepartments();
    }
}
