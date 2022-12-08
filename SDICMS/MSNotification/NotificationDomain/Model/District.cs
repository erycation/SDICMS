using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_District")]
    public class District
    {
        public District()
        {
            this.PoliceStations = new HashSet<PoliceStation>();
        }
        [Key]
        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }
        [ForeignKey("Province")]
        public int? ProvinceId { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<PoliceStation> PoliceStations { get; set; }

    }
}