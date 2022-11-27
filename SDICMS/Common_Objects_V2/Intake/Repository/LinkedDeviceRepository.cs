

using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Repository
{
    public class LinkedDeviceRepository : IntakeRepository<LinkedDevice>, ILinkedDeviceRepository
    {

        public LinkedDeviceRepository(IntakeDBContext intakeDBContext) : base(intakeDBContext)
        {

        }

        public async Task<LinkedDevice> CreateLinkDevice(LinkedDevice linkedDevice)
        {
            await _intakeDBContext.LinkedDevices.AddAsync(linkedDevice);
            await _intakeDBContext.SaveChangesAsync();
            return linkedDevice;
        }

        public async Task<LinkedDevice> GetDeviceByDeviceId(string deviceId)
        {
            return await _intakeDBContext.LinkedDevices.SingleOrDefaultAsync(l => l.DeviceId == deviceId);
        }

        public async Task<List<LinkedDevice>> GetLinkedDevicesByUserId(int userId)
        {
            return await _intakeDBContext.LinkedDevices.Where(l => l.UserId == userId).ToListAsync();
        }

        public async Task<LinkedDevice> GetActiveLinkedDeviceByDeviceId(string deviceId)
        {
            return await _intakeDBContext.LinkedDevices.SingleOrDefaultAsync(l =>  l.DeviceId == deviceId && l.Active == true);
        }       

        public async Task<LinkedDevice> UpdateLinkedDevice(LinkedDevice linkedDevice)
        {
            _intakeDBContext.LinkedDevices.Update(linkedDevice);
            await _intakeDBContext.SaveChangesAsync();
            return linkedDevice;
        }
    }
}

