using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;
using OneOfAKindSupreme.Frontend.Core.Models;

namespace OneOfAKindSupreme.Frontend.UseCases.Access
{
    public class SignIn : ISignIn
    {
        private readonly IAuthenticationApi api;
        public SignIn(IAuthenticationApi api) 
        { 
            this.api = api; 
        }
        public async Task<Result<AuthenticationToken>> ValidateCredentials(string userName, string password)
        {

            Result<AuthenticationToken> result = new();

            try
            {
                var authenticationToken = await api.Login(userName, password);
                result.IsSuccess = true;
                result.Data = authenticationToken;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;

                // TODO:  Return friendly message.
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
