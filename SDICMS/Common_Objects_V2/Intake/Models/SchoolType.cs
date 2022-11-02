using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_School_Type")]
    public class SchoolType
    {
        public SchoolType()
        {
            this.Schools = new HashSet<School>();
        }
        [Key]
        public int School_Type_Id { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Definition { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
