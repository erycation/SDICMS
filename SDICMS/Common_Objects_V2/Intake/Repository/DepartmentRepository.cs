using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class DepartmentRepository : IntakeRepository<Department>, IDepartmentRepository
    {

        public DepartmentRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _intakeDBContext.Departments.SingleOrDefaultAsync(d => d.Department_Id == departmentId);
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _intakeDBContext.Departments.ToListAsync();
        }
    }
}