
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_Province")]
    public class Province
    {
        public Province()
        {
            this.Districts = new HashSet<District>();
        }

        [Key]
        public int ProvinceId { get; set; }
        public string? ProvinceName { get; set; }
        public string? ProvinceCode { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}