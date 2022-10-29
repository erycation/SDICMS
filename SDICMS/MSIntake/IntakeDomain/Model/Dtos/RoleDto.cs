namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class RoleDto
    {
        public int Role_Id { get; set; }
        public string Description { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Date_Created { get; set; }
    }
}
