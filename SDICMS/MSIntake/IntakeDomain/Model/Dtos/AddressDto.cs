namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class AddressDto
    {
        public int Address_Id { get; set; }
        public int? Address_Type_Id { get; set; }
        public string? Address_Line_1 { get; set; }
        public string? Address_Line_2 { get; set; }
        public int? Town_Id { get; set; }
        public string? Postal_Code { get; set; }
        public AddressTypeDto AddressTypeDto { get; set; }
        public string AddressType
        {
            get
            {
                return AddressTypeDto?.Description;
            }
        }
    }
}
