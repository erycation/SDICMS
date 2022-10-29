using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IRoleRepository _roleRepository;

        public RoleService(IMapper mapper,
                            IRoleRepository roleRepository)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<RoleDto> CreateRole(RoleDto roleDto)
        {
            var requestRole = new Role{ Description = roleDto.Description };
            var responseRole = await _roleRepository.CreateRole(requestRole);
            if (responseRole == null)
                throw new AppException($"Error creating role.");
            return _mapper.Map<RoleDto>(responseRole);
        }

        public async Task<List<RoleDto>> GetListOfRoles()
        {
            var responseRoles = await _roleRepository.GetListOfRoles();
            return _mapper.Map<List<RoleDto>>(responseRoles);
        }

        public async Task<RoleDto> GetRoleById(int roleId)
        {
            var responseRole = await _roleRepository.GetRoleById(roleId);
            return _mapper.Map<RoleDto>(responseRole);
        }

        public async Task<RoleDto> SetRoleIsActive(RoleDto roleDto)
        {
            var responseRole = await _roleRepository.GetRoleById(roleDto.Role_Id);
            if (responseRole == null)
                throw new AppException($"Role not exist.");
            responseRole.Is_Active = true;
            responseRole.Is_Deleted = false;
            var responseUpdatedRole = await _roleRepository.UpdateRole(responseRole);
            return _mapper.Map<RoleDto>(responseUpdatedRole);
        }

        public async Task<RoleDto> SetRoleIsDeleted(RoleDto roleDto)
        {
            var responseRole = await _roleRepository.GetRoleById(roleDto.Role_Id);
            if (responseRole == null)
                throw new AppException($"Role not exist.");
            responseRole.Is_Deleted = true;
            responseRole.Is_Active = false;
            var responseUpdatedRole = await _roleRepository.UpdateRole(responseRole);
            return _mapper.Map<RoleDto>(responseUpdatedRole);
        }
    }
}
