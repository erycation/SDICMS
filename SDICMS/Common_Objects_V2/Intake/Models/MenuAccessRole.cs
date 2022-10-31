using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Menu_Access_Role")]
    public class MenuAccessRole
    {
        [ForeignKey("MenuAccess")]
        public int Menu_Access_Id { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }
        public virtual MenuAccess MenuAccess { get; set; }
        public virtual Role Role { get; set; }
    }
}
