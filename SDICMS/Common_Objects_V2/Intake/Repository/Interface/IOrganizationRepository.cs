using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface IOrganizationRepository
    {
        Task<Organization> GetOrganizationById(int organizationId);
        Task<List<Organization>> GetOrganizationByLocalMicipalilityId(int localMunicipalityId);
    }
}
