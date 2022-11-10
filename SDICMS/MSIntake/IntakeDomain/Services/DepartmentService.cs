using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IMapper mapper,
                              IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }

        public async Task<List<DepartmentDto>> GetDepartments()
        {
            var responseDepartment = await _departmentRepository.GetDepartments();
            return _mapper.Map<List<DepartmentDto>>(responseDepartment);
        }

        public async Task<DepartmentDto> GetDepartmentById(int departmentId)
        {
            var responseDepartment = await _departmentRepository.GetDepartmentById(departmentId);
            return _mapper.Map<DepartmentDto>(responseDepartment);
        }
    }
}