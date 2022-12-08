using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("Country")]
    public class Country
    {
        public Country()
        {
            this.ChildInformations = new HashSet<ChildInformation>();
        }

        [Key]
        public int CountyId { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public virtual ICollection<ChildInformation> ChildInformations { get; set; }
    }
}
