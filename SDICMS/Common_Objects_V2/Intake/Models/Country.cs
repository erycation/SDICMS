

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Country")]
    public class Country
    {
        public Country()
        {
            this.Provinces = new HashSet<Province>();
        }
        [Key]
        public int Country_Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
