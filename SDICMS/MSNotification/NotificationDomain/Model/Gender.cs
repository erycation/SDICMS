using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_Gender")]
    public class Gender
    {
        public Gender()
        {
            this.ChildInformations = new HashSet<ChildInformation>();
        }

        [Key]
        public int PersonGenderCodeID { get; set; }
        public string? PersonGender { get; set; }
        public string? PersonGenderCode { get; set; }
        public virtual ICollection<ChildInformation> ChildInformations { get; set; }
    }
}
