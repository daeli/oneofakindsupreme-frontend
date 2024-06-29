using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using System.Net.Http.Headers;
using System.Text;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class Api : IApi
    {
        private readonly string token = "CfDJ8HP3uywBVL5Nl1AY_8PhcZSGtX-sw8uZlVDxII_kzZgtdl57HVCIoshQJCjYBiQvsXowul1rDnsm7xA5HtE3m8eJaKhBHHY9QIcN_6IargV10RxKPbc3Ku9fPWRVPg_8B0PRIuQnMJ4Bf47MluG47B1dk9NqJhXAoGdpSUrxzodDykhqQix2Pul6TyKEl2WyEHMYSFAujWsmITdjxysZoG_5nn2cFPH4NJiWXEI9i0jIxU8lWLQsKBKep59OKur4fmTSLqUSKWgBTTYSG2YBllZryLcX4o9hnRV4Sn-G8v5SiVLz8k0XFaeMXqoOcb6FQhXHnVqkVQfTw4R40oW8iULEv63kP8TnvYZ7v7qouuY2GAUcc3gWdO5k7uvZzzAYbyG2qiPHs24wcz2pWOJgdwrmoGeNARYvNLzeqjXQ6FD4qWWZyLe2Mn_tSqoQNDkq8HlEr6-YbExKDtc4VTRw6qq4CAxqOmeONOKbht3Bt5so-u-lRR71QI7Cg_huiNP6RxZuuvfiDCdxpvdLP2ycczvGN-ShoHlAMDZzukR9LHYGpOmeF5LZpHcMyhD9VI-dzoecIN-MXBqEYYXJ4JIyL1osMWAtuVsePjff8E1kN2TFGzd9GVXV-1X56pVkWIAIMBqh_IYOBngxZSFxM0A144m_MFdqRIcJvSTk1a5cJC7yNsBNElj8smfj-h76JOsI4g";

        // TODO:  Get base url from configuraton.
        public const string BaseUrl = "https://localhost:7230";

        private HttpClient GetClient(string endpoint) 
        {
            var url = BaseUrl;
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri($"{url}{endpoint}")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return client;
        }

        public async Task<T?> GetFromApiAsync<T>(string endpoint) 
        {
            var client = GetClient(endpoint);

            HttpResponseMessage response = await client.GetAsync(endpoint).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();                
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            
            return default;
        }

        public async Task<T?> PostToApiAsync<T>(string endpoint, IApiDto data)
        {
            var client = GetClient(endpoint);

            var jsonData = JsonConvert.SerializeObject(data);
            var requestContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(endpoint, requestContent).ConfigureAwait(false);

            if (response.IsSuccessStatusCode) 
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            return default;
        }
    }
}
