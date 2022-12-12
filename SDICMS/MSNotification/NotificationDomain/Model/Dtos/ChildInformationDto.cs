namespace MSChildNotification.NotificationDomain.Model.Dtos
{
    public class ChildInformationDto
    {
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
        public int? PersonGenderCodeID { get; set; }
        public int? PersonLanguageCodeID { get; set; }
        public int? RaceId { get; set; }
        public int? IdentityTypeId { get; set; }
        public int? CountyId { get; set; }
        public virtual GenderDto GenderDto { get; set; }
        public virtual IdentityTypeDto IdentityTypeDto { get; set; }
        public virtual LanguageDto LanguageDto { get; set; }
        public virtual RaceDto RaceDto { get; set; }
        public virtual CountryDto CountryDto { get; set; }
    }
}
