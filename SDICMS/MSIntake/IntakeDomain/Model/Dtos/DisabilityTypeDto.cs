namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class DisabilityTypeDto
    {
        public int DisabilityType_Id { get; set; }
        public int? DisabilityId { get; set; }
        public string? TypeName { get; set; }
        public DisabilityDto DisabilityDto { get; set; }
    }
}
