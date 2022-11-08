using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class RelationshipTypeService : IRelationshipTypeService
    {
        private readonly IMapper _mapper;
        private readonly IRelationshipTypeRepository _relationshipTypeRepository;

        public RelationshipTypeService(IMapper mapper,
                                  IRelationshipTypeRepository relationshipTypeRepository)
        {
            _mapper = mapper;
            _relationshipTypeRepository = relationshipTypeRepository;
        }

        public async Task<List<RelationshipTypeDto>> GetRelationshipTypes()
        {
            var responseRelationshipType = await _relationshipTypeRepository.GetRelationshipTypes();
            return _mapper.Map<List<RelationshipTypeDto>>(responseRelationshipType);
        }

        public async Task<RelationshipTypeDto> GetRelationshipTypeById(int relationshipTypeId)
        {
            var responseRelationshipType = await _relationshipTypeRepository.GetRelationshipTypeById(relationshipTypeId);
            return _mapper.Map<RelationshipTypeDto>(responseRelationshipType);
        }
    }
}