namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class MenuAccessDto
    {
        public int Menu_Access_Id { get; set; }
        public string Description { get; set; }
        public bool IsModule { get; set; }
        public int? ParentId { get; set; }
        public string Route { get; set; }
        public bool Is_Active { get; set; } = true;
        public bool Is_Deleted { get; set; } = false;
        public DateTime Date_Created { get; set; } = DateTime.Now;
        public string Created_By { get; set; }
    }
}
