using System;
using LoLAPI.API;
using LoLAPI.Enums;
using LoLAPI.Classes;
using System.Threading.Tasks;

namespace LoLAPI.EndPoints
{
    public class SummonerManager : LolEndPoint<Summoner>
    {
        public static async Task<Summoner> GetByName(string summonerName)
         {
             var summoner = await GetAsync(RegionEnum.la1, $"summoners/by-name/{summonerName}");
             return summoner;
         }
         
        public SummonerManager()
        {
            
        }
    }
}