using System;
using System.Threading.Tasks;
using LoLAPI.API;
using LoLAPI.Classes;
using LoLAPI.Enums;

namespace LoLAPI.EndPoints
{
    public class AccountManager : LolEndPoint<Account>
    {
        public static async Task<Account> ByPuuId(RegionEnum region, string puuid)
        {

            var url = await GetAsync(region, $"accounts/by-puuid/{puuid}");
            return url;
        }

        public AccountManager()
        {
            
        }
    }
}