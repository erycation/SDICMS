using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IMapper _mapper;
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IMapper mapper,
                            IOrganizationRepository organizationRepository)
        {
            _mapper = mapper;
            _organizationRepository = organizationRepository;
        }

        public async Task<OrganizationDto> GetOrganizationById(int organizationId)
        {
            var responseOrganization = await _organizationRepository.GetOrganizationById(organizationId);
            return _mapper.Map<OrganizationDto>(responseOrganization);
        }

        public async Task<List<OrganizationDto>> GetOrganizationByLocalMicipalilityId(int localMunicipalityId)
        {
            var responseOrganizations = await _organizationRepository.GetOrganizationByLocalMicipalilityId(localMunicipalityId);
            return _mapper.Map<List<OrganizationDto>>(responseOrganizations);
        }
    }
}