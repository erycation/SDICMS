using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_District")]
    public class District
    {

        public District()
        {
            this.LocalMunicipalities = new HashSet<LocalMunicipality>();
        }

        [Key]
        public int District_Id { get; set; }
        [ForeignKey("Province")]
        public int Province_Id { get; set; }
        public string Description { get; set; }        
        public virtual Province Province { get; set; }
        public virtual ICollection<LocalMunicipality> LocalMunicipalities { get; set; }

    }
}