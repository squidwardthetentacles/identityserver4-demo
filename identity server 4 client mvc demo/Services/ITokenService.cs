using IdentityModel.Client;

namespace identity_server_4_client_mvc_demo.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
