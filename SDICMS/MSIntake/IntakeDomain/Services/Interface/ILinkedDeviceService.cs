using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ILinkedDeviceService
    {
        Task<LinkedDeviceDto> CreateLinkDevice(LinkedDeviceDto linkedDeviceDto);
        Task<LinkedDeviceDto> GetDeviceByDeviceId(string deviceId);
        Task<LinkedDeviceDto> GetActiveLinkedDeviceByDeviceId(string deviceId);
        Task<List<LinkedDeviceDto>> GetLinkedDevicesByDeviceId(int userId);
        Task<LinkedDeviceDto> UpdateLinkedDevice(LinkedDeviceDto linkedDeviceDto);

        //Task<List<LinkedDeviceDto>> GetLinkedDevicesByUserId(int userId);
        //Task<LinkedDeviceDto> GetDeviceByDeviceId(string deviceId);
        //Task<LinkedDeviceDto> UpdateLinkedDevice(LinkedDeviceDto linkedDeviceDto);
    }
}
