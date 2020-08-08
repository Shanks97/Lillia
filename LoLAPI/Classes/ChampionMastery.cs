using System;
using LoLAPI.Attributes;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(4, GameEnum.lol, EndPointEnum.champion_mastery)]
    public class ChampionMastery
    {
        public long ChampionPointsUntilNextLevel { get; set; }
        public bool ChestGranted { get; set; }
        public long ChampionId { get; set; }
        public long LastPlayTime { get; set; }
        public int ChampionPoints { get; set; }
        public long ChampionPointsSinceLastLevel { get; set; }
        public int TokensEarned { get; set; }

        public ChampionMastery()
        {
            
        }
    }
}