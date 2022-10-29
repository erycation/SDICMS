namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class GroupDto
    {
        public int Group_Id { get; set; }
        public string Description { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Date_Created { get; set; }
        public string Created_By { get; set; }
    }
}
