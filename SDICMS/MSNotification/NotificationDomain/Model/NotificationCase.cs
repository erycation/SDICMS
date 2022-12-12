namespace MSChildNotification.NotificationDomain.Model
{
    public class NotificationCase
    {
        public int CaseInformationId { get; set; }
        public int NotificacationId { get; set; }
        public string? MessageRefNumber { get; set; }
        public string? CaseStatus { get; set; }
        public string? MessageSourceName { get; set; }
        public string? MessageSource { get; set; }
        public DateTime? NotificationDate { get; set; }
        public byte[] Timestamp { get; set; }
        public string? NotificationTypeVersion { get; set; }
        public int? EmployeeDetailsId { get; set; }
        public string? Surname { get; set; }
        public string? FirstName { get; set; }
        public string? PersalNo { get; set; }
        public string? ContactNumber { get; set; }
        public int PoliceStationId { get; set; }
        public string? PoliceStationName { get; set; }
        public string? CasNumber { get; set; }
        public int? HoursLeft { get; set; }
        public int? SupervisorId { get; set; }
        public int? RespondStatus { get; set; }
        public int SAPSInfoId { get; set; }
        public string? PoliceFullNames { get; set; }
        public string? PoliceUnitName { get; set; }
        public string? PoliceOfficerContact { get; set; }
        public string? ComponentCode { get; set; }
        public string? RankDescription { get; set; }
        public string? POName { get; set; }
        public string? POSurname { get; set; }
        public int ChildInformationId { get; set; }        
        public string? ChildName { get; set; }
        public DateTime? ChildDateOfBirth { get; set; }
        public DateTime? OfficerAssignedDate { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string? ArrestTime { get; set; }
        public string? OffenseType { get; set; }        

    }
}
