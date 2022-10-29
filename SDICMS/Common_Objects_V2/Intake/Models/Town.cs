using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Town")]
    public class Town
    {
        [Key]
        public int Town_Id { get; set; }
        [ForeignKey("LocalMunicipality")]
        public int Local_Municipality_Id { get; set; }
        public string Description { get; set; }
        public string PostalCode { get; set; }
        public virtual LocalMunicipality LocalMunicipality { get; set; }
    }
}
