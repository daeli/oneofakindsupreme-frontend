
using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs
{
    public class LoginCredentials : IApiDto
    {
        public string email {  get; set; }
        public string password { get; set; }
    }
}
