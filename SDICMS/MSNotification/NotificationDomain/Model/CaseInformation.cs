using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSChildNotification.NotificationDomain.Model
{
    [Table("CaseInformation")]
    public class CaseInformation
    {
        [Key]
        public int CaseInformationID { get; set; }
        public string? CasNumber { get; set; }
        public int? SAPSInfoId { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string? ArrestTime { get; set; }
        //[ForeignKey("ChildInformation")]
        public int? ChildInformationID { get; set; }
        public int? ProbationOfficerInformationID { get; set; }
        public DateTime? ProbationOfficerEstimatedArrivalTime { get; set; }
        public string? ProbationOfficerContactTypeId { get; set; }
        public DateTime? ProbationOfficerAllocatedDate { get; set; } = DateTime.Now;
        public string? TimeAssigned { get; set; }
        public int? NotificacationId { get; set; }
        public string? OffenseType { get; set; }

        //public virtual CaseInformation CaseInformation1 { get; set; }
        //public virtual CaseInformation CaseInformation2 { get; set; }
        //public virtual ChildInformation ChildInformation { get; set; }
    }
}
