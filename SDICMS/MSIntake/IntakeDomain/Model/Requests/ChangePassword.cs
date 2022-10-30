namespace MSIntake.IntakeDomain.Model.Requests
{
    public class ChangePassword
    {
        public int UserId { set; get; }
        public string? Password { set; get; }
        public string? ConfirmPassword { set; get; }
    }
}
