using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_OffenseType")]
    public class OffenseType
    {
        [Key]
        public int OffenseCodeId { get; set; }
        public string? OffenseDescription { get; set; }
        public string? OffenseCode { get; set; }
        public string? OffenseCategory { get; set; }
    }
}
