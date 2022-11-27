using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Linked_Device")]
    public class LinkedDevice
    {
        [Key]
        public int Linked_Device_Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string DeviceId { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public virtual User User { get; set; }
    }
}

