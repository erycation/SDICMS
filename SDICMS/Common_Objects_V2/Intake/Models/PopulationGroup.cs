using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Population_Group")]
    public class PopulationGroup
    {
        [Key]
        public int Population_Group_Id { get; set; }
        public string Description { get; set; }
        public string? Source { get; set; }
        public string? Definition { get; set; }
    }
}

