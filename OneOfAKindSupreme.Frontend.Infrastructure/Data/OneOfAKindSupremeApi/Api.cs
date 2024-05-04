using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class Api : IApi
    {
        // TODO:  Get base url from configuraton.
        public const string BaseUrl = "https://localhost:7230";

        public async Task<T> List<T>(string endpoint) 
        {
            var url = BaseUrl;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{BaseUrl}{endpoint}");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(endpoint).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
               return JsonConvert.DeserializeObject<T>(jsonString);
            }
            
            return default;
        }
    }
}
