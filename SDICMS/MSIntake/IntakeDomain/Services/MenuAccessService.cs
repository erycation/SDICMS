using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class MenuAccessService : IMenuAccessService
    {
        private readonly IMapper _mapper;
        private readonly IMenuAccessRepository _menuAccessRepository;
        private readonly IMenuAccessRoleService _menuAccessRoleService; 

        public MenuAccessService(IMapper mapper,
                            IMenuAccessRepository menuAccessRepository,
                            IMenuAccessRoleService menuAccessRoleService)
        {
            _mapper = mapper;
            _menuAccessRepository = menuAccessRepository;
            _menuAccessRoleService = menuAccessRoleService;
        }

        public async Task<MenuAccessDto> CreateMenuAccess(RegisterMenuAccess registerMenuAccess)
        {
            var responseMenuAccess = await _menuAccessRepository.GetMenuAccessByName(registerMenuAccess.Description);
            if (responseMenuAccess != null)
                throw new AppException($"Menu {registerMenuAccess.Description} exist.");
            if (!registerMenuAccess.IsModule)
            {
                if (registerMenuAccess.ParentId == null)
                    throw new AppException($"Parent menu required.");

                var responseParentMenu = await _menuAccessRepository.GetMenuAccessById((int)registerMenuAccess.ParentId);
                if (responseParentMenu == null)
                    throw new AppException($"Parent menu not valid.");
            }
            else
            {
                registerMenuAccess.ParentId = null;
            }
            //check if roles are more that one
            if (registerMenuAccess.RolesDto == null)
                throw new AppException($"Menu roles required.");

            var menuAccess = new MenuAccess
            {
                Description = registerMenuAccess.Description,
                IsModule = registerMenuAccess.IsModule,
                ParentId = registerMenuAccess.ParentId,
                Route = registerMenuAccess.Route,
                Created_By = registerMenuAccess.Created_By
            };

            var responseSaveMenu = await _menuAccessRepository.CreateMenuAccess(menuAccess);
            if (responseSaveMenu != null)
            {
                var menuAccessRolesDto = new List<MenuAccessRoleDto>();
                foreach (var roleDto in registerMenuAccess.RolesDto)
                    menuAccessRolesDto.Add(new MenuAccessRoleDto { Menu_Access_Id = responseSaveMenu.Menu_Access_Id, Role_Id = roleDto.Role_Id });
                _menuAccessRoleService.CreateBulkMenuAccessRole(menuAccessRolesDto);
            }
            return _mapper.Map<MenuAccessDto>(responseSaveMenu);
        }

        public async Task<List<MenuAccessDto>> GetMenuAccessByRolesId(List<int> roleIds)
        {
            var responseMenuAccessRoles = await _menuAccessRepository.GetMenuAccessByRolesId(roleIds);
             return _mapper.Map<List<MenuAccessDto>>(responseMenuAccessRoles);
          }
    }
}
