namespace MSChildNotification.NotificationDomain.Model.Dtos
{
    public class CaseInformationDto
    {
        public int CaseInformationID { get; set; }
        public string? CasNumber { get; set; }
        public int? SAPSInfoId { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string? ArrestTime { get; set; }
        public int? ChildInformationID { get; set; }
        public int? ProbationOfficerInformationID { get; set; }
        public DateTime? ProbationOfficerEstimatedArrivalTime { get; set; }
        public string? ProbationOfficerContactTypeId { get; set; }
        public DateTime? ProbationOfficerAllocatedDate { get; set; }
        public string? TimeAssigned { get; set; }
        public int? NotificacationId { get; set; }
        public string? OffenseType { get; set; }
    }
}
