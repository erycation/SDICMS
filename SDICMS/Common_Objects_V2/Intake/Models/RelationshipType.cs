using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common_Objects_V2.Intake.Models
{
    [Table("apl_Relationship_Type")]
    public class RelationshipType
    {
        [Key]
        public int Relationship_Type_Id { get; set; }
        public string Description { get; set; }
        public string? Source { get; set; }
        public string? Definition { get; set; }
    }
}

