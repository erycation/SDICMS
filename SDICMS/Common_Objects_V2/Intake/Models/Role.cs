using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Role")]
    public class Role
    {

        public Role()
        {
            this.Groups = new HashSet<Group>();
            this.UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public int Role_Id { get; set; }
        public string Description { get; set; }
        public bool Is_Active { get; set; } = true;
        public bool Is_Deleted { get; set; } = false;
        public DateTime Date_Created { get; set; } = DateTime.Now;
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
