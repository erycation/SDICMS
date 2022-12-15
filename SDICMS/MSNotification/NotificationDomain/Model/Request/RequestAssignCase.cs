namespace MSChildNotification.NotificationDomain.Model.Request
{
    public class RequestAssignCase
    {
        public int NotificationId { get; set; }
        public int ProbationOfficerId { get; set; }
        public int CaseInformationId { get; set; }
        public int ContactTypeId { get; set; }
        public DateTime? EstimatedArrivalTime { get; set; }        
    }
}
