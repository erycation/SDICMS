namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class TownDto
    {
        public int Town_Id { get; set; }
        public int Local_Municipality_Id { get; set; }
        public string Description { get; set; }
        public string PostalCode { get; set; }
    }
}
