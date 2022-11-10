
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Disability")]
    public class Disability
    {
        public Disability()
        {
            this.DisabilityTypes = new HashSet<DisabilityType>();
        }

        [Key]
        public int Disability_Id { get; set; }
        public string Description { get; set; }
        public string? Source { get; set; }
        public string? Definition { get; set; }
        public virtual ICollection<DisabilityType> DisabilityTypes { get; set; }
    }
}
