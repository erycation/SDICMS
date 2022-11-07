using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_AuditTrial")]
    public class AuditTrial
    {       

        [Key]
        public int Apl_AuditTrial_Id { get; set; }
        public string? Taskperformed { get; set; }
        public DateTime? Datecaptured { get; set; } = DateTime.Now;
        public string? Module { get; set; }
        public string? Username { get; set; }
        public string? Serviceoffice { get; set; }
        public string? Organisation { get; set; }
    }
}
