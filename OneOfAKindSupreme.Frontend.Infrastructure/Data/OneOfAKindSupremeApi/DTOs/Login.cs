
namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs
{
    public class Login
    {
        public string? tokenType { get; set; }
        public string? accessToken { get; set; }
        public string? refreshToken { get; set; }
        public int expiresIn { get; set; }
    }
}
