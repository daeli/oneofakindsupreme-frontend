using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses
{
    public class CreateNewProjectResponse
    {
        [JsonProperty("data")]
        public Project? Project { get; set; }
    }
}
