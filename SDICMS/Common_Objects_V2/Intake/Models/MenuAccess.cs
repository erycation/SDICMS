 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Menu_Access")]
    public class MenuAccess
    {
        public MenuAccess()
        {
            this.MenuAccessRoles = new HashSet<MenuAccessRole>();
        }
        [Key]
        public int Menu_Access_Id { get; set; }
        public string Description { get; set; }
        public bool IsModule { get; set; }
        public int? ParentId { get; set; }
        public string Route { get; set; }
        public bool Is_Active { get; set; } = true;
        public bool Is_Deleted { get; set; } = false;
        public DateTime Date_Created { get; set; } = DateTime.Now;
        public string Created_By { get; set; }
        public virtual ICollection<MenuAccessRole> MenuAccessRoles { get; set; }
    }
}
