using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Organization")]
    public class Organization
    {
        [Key]
        public int Organization_Id { get; set; }
        public string Description { get; set; }
        public string Telephone_Number { get; set; }
        public string Fax_Number { get; set; }
        public string Email_Address { get; set; }
        public string NPO_Number { get; set; }
        public int? Organisation_Type_Id { get; set; }
        public string Registration_Number { get; set; }
        public string Site_Code { get; set; }
        public string Address { get; set; }
        [ForeignKey("LocalMunicipality")]
        public int? Local_Municipality_Id { get; set; }
        public DateTime Date_Created { get; set; }
        public string Created_By { get; set; }
        public DateTime? Date_Last_Modified { get; set; }
        public string Modified_By { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public virtual LocalMunicipality LocalMunicipality { get; set; }

    }
}
