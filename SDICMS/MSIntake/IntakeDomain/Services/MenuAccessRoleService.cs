using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class MenuAccessRoleService : IMenuAccessRoleService
    {
        private readonly IMapper _mapper;
        private readonly IMenuAccessRoleRepository _menuAccessRoleRepository;

        public MenuAccessRoleService(IMapper mapper,
                            IMenuAccessRoleRepository menuAccessRoleRepository)
        {
            _mapper = mapper;
            _menuAccessRoleRepository = menuAccessRoleRepository;
        }

        public void CreateBulkMenuAccessRole(List<MenuAccessRoleDto> menuAccessRoleDtos)
        {
            var menuAccessRoles = new List<MenuAccessRole>();
            foreach (var menuAccessRoleDto in menuAccessRoleDtos)
                menuAccessRoles.Add(new MenuAccessRole { Menu_Access_Id = menuAccessRoleDto.Menu_Access_Id, Role_Id = menuAccessRoleDto.Role_Id });
            _menuAccessRoleRepository.CreateBulkMenuAccessRole(menuAccessRoles);

        }
    }
}
