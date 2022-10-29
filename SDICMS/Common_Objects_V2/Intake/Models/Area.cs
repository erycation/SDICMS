using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Area")]
    public class Area
    {
        public Area()
        {
            this.Municipalities = new HashSet<Municipality>();
        }
        [Key]
        public int Area_Id { get; set; }
        public int District_Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}
