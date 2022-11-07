using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Contact_Type")]
    public class ContactType
    {
        [Key]
        public int Contact_Type_Id { get; set; }
        public string Description { get; set; }
    }
}
