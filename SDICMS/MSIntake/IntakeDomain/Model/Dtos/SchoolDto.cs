namespace MSIntake.IntakeDomain.Model.Dtos
{
    public class SchoolDto
    {
        public int School_Id { get; set; }
        public int? School_Type_Id { get; set; }
        public string School_Name { get; set; }
        public string Contact_Person { get; set; }
        public string Telephone_Number { get; set; }
        public string Cellphone_Number { get; set; }
        public string Fax_Number { get; set; }
        public string Email_Address { get; set; }
        public DateTime Date_Created { get; set; }
        public string Created_By { get; set; }
        public DateTime? Date_Last_Modified { get; set; }
        public string Modified_By { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public string NatEmis { get; set; }
    }
}
