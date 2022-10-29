
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{

    [Table("apl_Municipality")]
    public class Municipality
    {
        [Key]
        public int Municipality_Id { get; set; }
        [ForeignKey("Area")]
        public int Area_Id { get; set; }
        public string Description { get; set; }
        public virtual Area Area { get; set; }
    }
}
