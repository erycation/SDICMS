using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Address_Type")]
    public class AddressType
    {
        public AddressType()
        {
            this.Addresses = new HashSet<Address>();
        }
        [Key]
        public int Address_Type_Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
