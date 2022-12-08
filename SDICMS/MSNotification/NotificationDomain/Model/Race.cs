using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_Race")]
    public class Race
    {
        public Race()
        {
            this.ChildInformations = new HashSet<ChildInformation>();
        }

        [Key]
        public int RaceId { get; set; }
        public string? RaceType { get; set; }
        public string? RaceCode { get; set; } 
        public virtual ICollection<ChildInformation> ChildInformations { get; set; }
    }
}
