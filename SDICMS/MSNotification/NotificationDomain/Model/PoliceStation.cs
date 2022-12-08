

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_PoliceStation")]
    public class PoliceStation
    {
        [Key]
        public int PoliceStationId { get; set; }
        public string? PoliceStationName { get; set; }
        public string? ComponentCode { get; set; }
        [ForeignKey("District")]
        public int? DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}