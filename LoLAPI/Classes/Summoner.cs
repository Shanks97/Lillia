using System;
using LoLAPI.Attributes;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(4, GameEnum.lol, EndPointEnum.summoner)]
    public class Summoner 
    {
        public string AccountId { get; set; }
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string PuuId { get; set; }
        public long SummonerLevel { get; set; }

        public Summoner()
        {
            
        }

        public string IconUrl() => $"http://ddragon.leagueoflegends.com/cdn/10.16.1/img/profileicon/{ProfileIconId}.png";
    }
}