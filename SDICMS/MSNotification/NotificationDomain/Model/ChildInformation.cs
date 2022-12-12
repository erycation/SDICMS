using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("ChildInformation")]
    public class ChildInformation
    {        
        public ChildInformation()
        {
            //this.CaseInformations = new HashSet<CaseInformation>();
        }
        [Key]
        public int ChildInformationId { get; set; }
        public decimal? PersonId { get; set; }
        public string? PersonName { get; set; }
        public string? PersonLastName { get; set; }
        public DateTime? PersonDateOfBirth { get; set; }
        public int? PersonAge { get; set; }
        public string? PersonIDNumber { get; set; }
        public string? PersonFingerprintReference { get; set; }
        public DateTime? PersonArrestDateTime { get; set; }
        public DateTime? PersonReleasedDate { get; set; }
        [ForeignKey("Gender")]
        public int? PersonGenderCodeId { get; set; }
        [ForeignKey("Language")]
        public int? PersonLanguageCodeId { get; set; }
        [ForeignKey("Race")]
        public int? RaceId { get; set; }
        [ForeignKey("IdentityType")]
        public int? IdentityTypeId { get; set; }
        [ForeignKey("Country")]
        public int? CountyId { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual IdentityType IdentityType { get; set; }
        public virtual Language Language { get; set; }
        public virtual Race Race { get; set; }
        //public virtual ICollection<CaseInformation> CaseInformations { get; set; }
        public virtual Country Country { get; set; }
    }
}
