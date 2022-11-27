using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Requests;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IAuthenticateService
    {
        Task<AuthToken> Login(Credentials credentials);
        Task<AuthToken> MobileLogin(MobileCredentials mobileCredentials);
        Task<AuthToken> LoginToLinkDevice(LinkUserToMobile linkUserToMobile);
    }
}
