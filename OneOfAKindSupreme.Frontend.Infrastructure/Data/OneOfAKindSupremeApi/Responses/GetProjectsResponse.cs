using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses
{
    [Serializable]
    public class GetProjectsResponse
    {
        [JsonProperty("projects")]
        public IEnumerable<Project>? Projects { get; set; }
    }
}
