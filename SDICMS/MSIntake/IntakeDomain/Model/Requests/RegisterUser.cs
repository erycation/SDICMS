using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Model.Requests
{
    public class RegisterUser : UserDto
    {
        public string? Password { set; get; }
        public string? ConfirmPassword { set; get; }
    }
}
