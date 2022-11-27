namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class LinkedDeviceDto
    {
        public int Linked_Device_Id { get; set; }
        public int UserId { get; set; }
        public string DeviceId { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get { return Active ? "Active" : "Not Active"; } }
        public UserDto UserDto { get; set; }
    }
}
