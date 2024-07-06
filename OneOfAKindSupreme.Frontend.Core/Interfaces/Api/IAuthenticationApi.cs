using OneOfAKindSupreme.Frontend.Core.Models;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Api
{
    public interface IAuthenticationApi
    {
        Task<AuthenticationToken?> Login(string userName, string password);
    }
}
