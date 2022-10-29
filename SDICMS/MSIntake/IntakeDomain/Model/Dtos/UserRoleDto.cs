namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class UserRoleDto
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
        public RoleDto RoleDto { get; set; }
        public string RoleName
        {
            get
            {
                return RoleDto?.Description;
            }
        }
        public string RoleStatus
        {
            get
            {
                return (bool)(RoleDto?.Is_Active) ? "Active" : "Not Active";
            }
        }
    }
}
