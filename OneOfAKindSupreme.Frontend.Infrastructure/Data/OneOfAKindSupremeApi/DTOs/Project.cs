
using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs
{
    public class Project : IApiDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
    }
}
