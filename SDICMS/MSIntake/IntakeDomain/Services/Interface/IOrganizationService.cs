using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IOrganizationService
    {
        Task<OrganizationDto> GetOrganizationById(int organizationId);
        Task<List<OrganizationDto>> GetOrganizationByLocalMicipalilityId(int localMunicipalityId);
    }
}
