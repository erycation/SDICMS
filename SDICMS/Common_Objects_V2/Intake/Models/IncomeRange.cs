using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Income_Range")]
    public class IncomeRange
    {
        [Key]
        public int Income_Range_Id { get; set; }
        public string Description { get; set; }
        public string? Source { get; set; }
        public string? Definition { get; set; }
    }
}

