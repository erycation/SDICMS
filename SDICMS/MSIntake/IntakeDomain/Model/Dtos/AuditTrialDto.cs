namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class AuditTrialDto
    {
        public int Apl_AuditTrial_Id { get; set; }
        public string? Taskperformed { get; set; }
        public DateTime? Datecaptured { get; set; }
        public string? Module { get; set; }
        public string? Username { get; set; }
        public string? Serviceoffice { get; set; }
        public string? Organisation { get; set; }
    }
}
