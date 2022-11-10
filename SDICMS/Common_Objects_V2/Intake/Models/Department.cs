using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Department")]
    public class Department
    {
        [Key]
        public int Department_Id { get; set; }
        public string Description { get; set; }
    }
}
