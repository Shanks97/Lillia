using System;
using System.Collections.Generic;
using LoLAPI.Attributes;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(3, GameEnum.lol, EndPointEnum.champion)]
    public class  Champion
    {
        public int MaxNewPlayerLevel { get; set; }
        public List<int> FreeChampionIdsForNewPlayers { get; set; }
        public List<int> FreeChampionIds { get; set; }

        public Champion()
        {
            
        }
    }
}