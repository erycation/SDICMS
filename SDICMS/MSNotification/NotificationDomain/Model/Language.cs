using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("apl_Language")]
    public class Language
    {
        public Language()
        {
            this.ChildInformations = new HashSet<ChildInformation>();
        }

        [Key]
        public int PersonLanguageCodeID { get; set; }
        public string? PersonLanguage { get; set; }
        public string? PersonLanguageCode { get; set; }
        public virtual ICollection<ChildInformation> ChildInformations { get; set; }
    }
}
