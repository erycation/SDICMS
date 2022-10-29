using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_User_Role")]
    public class UserRole
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        //[NotMapped]
        //public string RoleDescribtion
        //{
        //    get
        //    {
        //        return Role?.Description;
        //    }
        //}

    }
}

