namespace MSChildNotification.NotificationDomain.Model.Dtos
{
    public class NotificationDto
    {
        public int NotificacationId { get; set; }
        public string? MessageRefNumber { get; set; }
        public string? MessageSourceName { get; set; }
        public string? MessageSource { get; set; }
        public DateTime? NotificationDate { get; set; }
        public byte[] Timestamp { get; set; }
        public string NotificationTypeVersion { get; set; }
        public int? ModuleId { get; set; }
        public int? RespondStatus { get; set; }
    }
}
