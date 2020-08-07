using ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.API
{
    public abstract class APIManager
    {
        public static readonly string BaseURL = "https://gobmx-apitest.azurewebsites.net/";

        private static readonly HttpClient _client = new HttpClient(new HttpClientHandler
        { ServerCertificateCustomValidationCallback = (____, ___, __, _) => true });

        protected static async Task<T> GetAsync<T>(string route) where T : class
        {
            var url = BaseURL + route;
            T obj = null;

            try
            {
                var response = await _client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                obj = JsonConvert.DeserializeObject<T>(responseBody);
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<T> PostAsync<T>(string route, object pairs) where T : class
        {
            var url = BaseURL + route;

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(pairs), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(url, content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch
            {
                return null;
            }
        }
    }
}
