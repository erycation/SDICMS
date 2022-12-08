using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("Notification")]
    public class Notification
    {
        [Key]
        public int NotificacationId { get; set; }
        public string? MessageRefNumber { get; set; }
        public string? MessageSourceName { get; set; }
        public string? MessageSource { get; set; }
        public DateTime? NotificationDate { get; set; }
        public byte[] Timestamp { get; set; }
        public string NotificationTypeVersion { get; set; }
        public int? ModuleId { get; set; }
        public int? RespondStatus { get; set; }

        //public virtual Module Module { get; set; }

    }
}