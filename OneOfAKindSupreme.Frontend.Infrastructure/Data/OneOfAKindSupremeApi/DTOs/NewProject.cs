using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs
{
    public class NewProject : IApiDto
    {
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
