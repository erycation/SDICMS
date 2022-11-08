using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class RelationshipTypeRepository : IntakeRepository<RelationshipType>, IRelationshipTypeRepository
    {

        public RelationshipTypeRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<RelationshipType> GetRelationshipTypeById(int relationshipTypeId)
        {
            return await _intakeDBContext.RelationshipTypes.SingleOrDefaultAsync(r => r.Relationship_Type_Id == relationshipTypeId);
        }

        public async Task<List<RelationshipType>> GetRelationshipTypes()
        {
            return await _intakeDBContext.RelationshipTypes.ToListAsync();
        }
    }
}