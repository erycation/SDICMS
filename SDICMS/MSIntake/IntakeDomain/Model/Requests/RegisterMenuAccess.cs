using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Model.Requests
{
    public class RegisterMenuAccess : MenuAccessDto
    {
        public virtual ICollection<RoleDto> RolesDto { get; set; }
    }
}
