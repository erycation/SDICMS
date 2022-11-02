namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class AuthToken
    {
        public int? UserId { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public virtual ICollection<UserRoleDto> UserRoleDtos { get; set; }
        public virtual ICollection<MenuAccessDto> MenuAccessDtos { get; set; }
    }
}
