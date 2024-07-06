using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.Models;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using OneOfAKindSupreme.Frontend.Infrastructure.Transforms;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class AuthenticationApi(IApi api) : IAuthenticationApi
    {
        public const string LoginEndpoint = "/login";

        private readonly IApi api = api;

        public async Task<AuthenticationToken?> Login(string userName, string password)
        {
            LoginResponse? response = await api.PostToApiAsync<LoginResponse>(LoginEndpoint, new LoginCredentials { email = userName, password = password });
            if (response != null)
            {
                return response.ToAuthenticationToken();
            }
            return null;
        }
    }
}