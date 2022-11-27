using Common_Objects_V2.Intake.Models;

namespace Common_Objects_V2.Intake.Repository.Interface
{
    public interface ILinkedDeviceRepository
    {
        Task<LinkedDevice> CreateLinkDevice(LinkedDevice linkedDevice);
        Task<List<LinkedDevice>> GetLinkedDevicesByUserId(int userId);
        Task<LinkedDevice> GetDeviceByDeviceId(string deviceId);
        Task<LinkedDevice> GetActiveLinkedDeviceByDeviceId(string deviceId);
        Task<LinkedDevice> UpdateLinkedDevice(LinkedDevice linkedDevice);
    }
}
