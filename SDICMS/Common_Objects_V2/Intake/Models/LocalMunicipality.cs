using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Local_Municipality")]
    public class LocalMunicipality
    {
        public LocalMunicipality()
        {
            this.Organizations = new HashSet<Organization>();
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int Local_Municipality_Id { get; set; }
        [ForeignKey("District")]
        public int District_Municipality_Id { get; set; }
        public string Description { get; set; }
        public virtual District District { get; set; }       
        public virtual ICollection<Organization> Organizations { get; set; }       
        public virtual ICollection<Town> Towns { get; set; }
    }
}
