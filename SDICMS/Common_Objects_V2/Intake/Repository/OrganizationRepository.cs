using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class OrganizationRepository : IntakeRepository<Organization>, IOrganizationRepository
    {

        public OrganizationRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<Organization> GetOrganizationById(int organizationId)
        {
            return await _intakeDBContext.Organizations.SingleOrDefaultAsync(o => o.Organization_Id == organizationId);
        }

        public async Task<List<Organization>> GetOrganizationByLocalMicipalilityId(int localMunicipalityId)
        {
            return await _intakeDBContext.Organizations.Where(o => o.Local_Municipality_Id == localMunicipalityId).ToListAsync();
        }
    }
}
