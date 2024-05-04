using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses
{
    [Serializable]
    public class GetProjectsResponse
    {
        [JsonProperty("projects")]
        public IEnumerable<Project>? Projects { get; set; }
    }
}
