using LoLAPI.Attributes;
using LoLAPI.EndPoints;
using LoLAPI.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.API
{
    public class LolEndPoint<T> where T : class
    {
        private static readonly string _baseUrl = "https://{0}.api.riotgames.com/";
        private static readonly string Token = "RGAPI-b4331fd7-26d4-4001-97fd-96dd9a9df6ef";
        private static HttpClient _client = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (____, ___, __, _) => true
            });
        static bool _init;

        private static string GetBaseURL(RegionEnum region)
        {   
            
          var attr = (EndPointAttribute) typeof(T).GetCustomAttributes(
            typeof(EndPointAttribute), true).
            FirstOrDefault();
              // Reflection.  
            
            return 
                string.Format(_baseUrl, region.ToString())
                + attr.Game.ToString().Replace('_', '-') + "/" 
                + attr.EndPointType +  "/"
                + "v"+ attr.Version + "/" ;
                //that will build something like
                //"https://la1.api.riotgames.com/lol/clash/"
        }

        

        protected static async Task<T> GetAsync(RegionEnum region, string route)
        {
            var url = GetBaseURL(region) + route;
            T obj = null;

            try
            {
                if(!_init)
                {
                    _init = true;
                    _client.DefaultRequestHeaders.Add("X-Riot-Token", Token);
                }

                var response = await _client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                System.Console.WriteLine(responseBody);
                obj = JsonConvert.DeserializeObject<T>(responseBody);
                return obj;
            }
            catch
            {               
                return null;
            }
        }

    }
}
