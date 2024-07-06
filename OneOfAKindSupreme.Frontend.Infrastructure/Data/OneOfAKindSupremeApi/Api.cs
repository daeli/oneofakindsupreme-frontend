using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using System.Net.Http.Headers;
using System.Text;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class Api : IApi
    {
        private readonly string token = "CfDJ8HP3uywBVL5Nl1AY_8PhcZSYR1mJnce0jbNpZCJQMUcnV802WcwurHtT_ThE8CPqo-8KGxQFtJzoa0V_6MnLWM0cKF4wnYUy41m5bhmWWbcETfMdnqgxaz5LLRtitZs_lHBFIUbRDCnP08Yz7nh2hLfOGTRcFztdAHIY9KFGoVgC1JPPMeR2OpGXncSXY3YMOr36xCU0IvpYf5gzZ2ATU6-OAoIZxbVmUGqRryvQHQib4vtNRL9kAaUjN5ZHPN3LqHMmNmyD3yJ-pJsibm-Gt15rNlR1SfaCCcf86UsaLhTytR2iV94NBC8iSr1Sg63doSombUi_bDpoif2zyOkAOcUS3Vo1ARhzM3QDYAZsVMhsFT0gL4mL7oOUWs7AYFvlaHA79UhCvcUZZX92eF3Q9OQ4Fb-t14i3u8xJDJGNFzhIMCV1OTfyk02aNjs0Yn7EFT0es3hf323Iip97BAmd7LJzLnagzPTUMHch1_-FQo06NjdrDdzZe9ISkDf5LuVH_Ab0_0eZORTRs8hZo3Cldrxfk1CAjXoBHZ_H7DEozclzSyMfBfG8_APdQoDwXiigpCVay6vqVgyaYjULwy2cvh29QzrXGWoY-sQbGkBVzyL8qMRB-a9FVzvV1mwylaUCy9ZLLKHUx_2P84eY-znuGf0dOdYfGVo9YsoeXC5SNKxCw07MH42vB3-z8yA4-mrhmg";

        private readonly HttpClient httpClient;

        private static readonly string contentType = "application/json";

        private static readonly string authHeaderType = "Bearer";

        public Api(HttpClient httpClient)
        { 
            this.httpClient = httpClient;
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authHeaderType, token);
        }

        public async Task<T?> GetFromApiAsync<T>(string endpoint) 
        {
            HttpResponseMessage response = await this.httpClient.GetAsync(endpoint).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();                
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            
            return default;
        }

        public async Task<T?> PostToApiAsync<T>(string endpoint, IApiDto data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var requestContent = new StringContent(jsonData, Encoding.UTF8, contentType);
            HttpResponseMessage response = await this.httpClient.PostAsync(endpoint, requestContent).ConfigureAwait(false);

            if (response.IsSuccessStatusCode) 
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            return default;
        }
    }
}
