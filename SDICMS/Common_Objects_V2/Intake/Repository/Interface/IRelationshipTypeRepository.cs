using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IRelationshipTypeRepository
    {
        Task<RelationshipType> GetRelationshipTypeById(int relationshipTypeId);
        Task<List<RelationshipType>> GetRelationshipTypes();
    }
}
