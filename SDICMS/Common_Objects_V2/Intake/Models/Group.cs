using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Group")]
    public class Group
    {
        public Group()
        {
            this.Roles = new HashSet<Role>();
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Group_Id { get; set; }
        public string Description { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Date_Created { get; set; } = DateTime.Now;
        public string Created_By { get; set; } 
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
