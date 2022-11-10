
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_DisabilityType")]
    public class DisabilityType
    {
        [Key]
        public int DisabilityType_Id { get; set; }
        [ForeignKey("Disability")]
        public int? DisabilityId { get; set; }
        public string? TypeName { get; set; }
        public virtual Disability Disability { get; set; }
    }
}
