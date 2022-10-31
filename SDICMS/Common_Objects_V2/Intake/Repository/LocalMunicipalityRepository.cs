using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class LocalMunicipalityRepository : IntakeRepository<LocalMunicipality>, ILocalMunicipalityRepository
    {

        public LocalMunicipalityRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }
        public async Task<LocalMunicipality> GetLocalMunicipalityById(int localMunicipalityId)
        {
            return await _intakeDBContext.LocalMunicipalities.SingleOrDefaultAsync(m => m.Local_Municipality_Id == localMunicipalityId);
        }

        public async Task<List<LocalMunicipality>> GetLocalMunicipalityByName(int districtId,string description)
        {
            return await _intakeDBContext.LocalMunicipalities.Where(l => l.Description.Contains(description) && l.District_Municipality_Id == districtId).ToListAsync();
        }

        public async Task<List<LocalMunicipality>> GetLocalMunicipalitiesByDistrictId(int districtId)
        {
            return await _intakeDBContext.LocalMunicipalities.Where(l => l.District_Municipality_Id == districtId).ToListAsync();
        }       
    }
}
