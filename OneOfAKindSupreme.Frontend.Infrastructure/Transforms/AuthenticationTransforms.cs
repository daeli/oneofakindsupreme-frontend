using OneOfAKindSupreme.Frontend.Core.Models;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Transforms
{
    public static class AuthenticationTransforms
    {
        public static AuthenticationToken ToAuthenticationToken(this Login login) 
        {
            return new AuthenticationToken { AccessToken = login.accessToken, RefreshToken = login.refreshToken, ExpiresIn = login.expiresIn };
        }
    }
}
