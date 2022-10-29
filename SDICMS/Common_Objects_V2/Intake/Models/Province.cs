

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Province")]
    public class Province
    {
        public Province()
        {
            this.Districts = new HashSet<District>();
            //this.PCM_D_ServicesProvider = new HashSet<PCM_D_ServicesProvider>();
            //this.ADS_Registration = new HashSet<ADS_Registration>();
            //this.cyca_Program_Enrolment = new HashSet<cyca_Program_Enrolment>();
            //this.cyca_Program_Enrolment1 = new HashSet<cyca_Program_Enrolment>();
            //this.CYCA_ProvincialCoordinator_Assigned_Centres = new HashSet<CYCA_ProvincialCoordinator_Assigned_Centres>();
        }

        [Key]
        public int Province_Id { get; set; }
        [ForeignKey("Country")]
        public int Country_Id { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        //public virtual ICollection<PCM_D_ServicesProvider> PCM_D_ServicesProvider { get; set; }
        //public virtual ICollection<ADS_Registration> ADS_Registration { get; set; }
        //public virtual ICollection<cyca_Program_Enrolment> cyca_Program_Enrolment { get; set; }
        //public virtual ICollection<cyca_Program_Enrolment> cyca_Program_Enrolment1 { get; set; }
        //public virtual ICollection<CYCA_ProvincialCoordinator_Assigned_Centres> CYCA_ProvincialCoordinator_Assigned_Centres { get; set; }
    }
}

