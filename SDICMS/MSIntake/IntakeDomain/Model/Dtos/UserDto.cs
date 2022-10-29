namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class UserDto
    {
        public int User_Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Initials { get; set; }
        public string? Email_Address { get; set; }
        public string? User_Name { get; set; }
        //public string? Password { get; set; }
        public DateTime? Date_Last_Login { get; set; }
        public DateTime? Date_Created { get; set; }
        public string? Created_By { get; set; }
        public DateTime? Date_Last_Modified { get; set; }
        public string? Modified_By { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public string? AccountStatus { get; set; }
        public int? Tries { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string? FirstTimeLogin { get; set; }
        public virtual ICollection<UserRoleDto> UserRoleDtos { get; set; }
    }
}
 