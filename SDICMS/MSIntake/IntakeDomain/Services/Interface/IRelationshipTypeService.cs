using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IRelationshipTypeService
    {
        Task<RelationshipTypeDto> GetRelationshipTypeById(int relationshipTypeId);
        Task<List<RelationshipTypeDto>> GetRelationshipTypes();
    }
}
