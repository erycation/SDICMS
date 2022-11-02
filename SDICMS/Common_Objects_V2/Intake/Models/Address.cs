using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Address")]
    public class Address
    {
        public Address()
        {
            //this.apl_School = new HashSet<apl_School>();
        }

        [Key]
        public int Address_Id { get; set; }
        [ForeignKey("AddressType")]
        public int? Address_Type_Id { get; set; }
        public string? Address_Line_1 { get; set; }
        public string? Address_Line_2 { get; set; }
        public int? Town_Id { get; set; }
        public string? Postal_Code { get; set; }

        public virtual AddressType AddressType { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<apl_School> apl_School { get; set; }
    }
}
