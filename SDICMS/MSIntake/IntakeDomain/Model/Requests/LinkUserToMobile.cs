namespace MSIntake.IntakeDomain.Model.Requests
{
    public class LinkUserToMobile
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string DeviceId { set; get; }
        public string? DeviceName { set; get; }
    }
}
