using System;
using LoLAPI.Attributes;
using LoLAPI.Classes.SubClasses;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(3, GameEnum.lol, EndPointEnum.league_exp)]
    public class LeagueExp
    {
        public string LeagueId { get; set; }
        public string SummonerId { get; set; }
        public string SummonerName { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int LeaguePoints { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public bool HotStreak { get; set; }
        public bool Veteran { get; set; }
        public bool FreshBlood { get; set; }
        public bool Inactive { get; set; }
        public MiniSeries MiniSeries { get; set; }

        public LeagueExp()
        {
            
        }
    }
}