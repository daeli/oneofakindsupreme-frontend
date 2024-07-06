using OneOfAKindSupreme.Frontend.Core.Models;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Domain
{
    public interface ISignIn
    {
        Task<Result<AuthenticationToken>> ValidateCredentials(string userName, string password);
    }
}