using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_IdentityType")]
    public class IdentityType
    {
        public IdentityType()
        {
            this.ChildInformations = new HashSet<ChildInformation>();
        }

        [Key]
        public int IdentityTypeId { get; set; }
        public string? IdentityDescrip { get; set; }
        public virtual ICollection<ChildInformation> ChildInformations { get; set; }
    }
}
