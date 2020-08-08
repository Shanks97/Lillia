using System;
using System.Collections.Generic;
using LoLAPI.Attributes;
using LoLAPI.Classes.SubClasses;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(4, GameEnum.lol, EndPointEnum.spectator)]
    public class Spectator 
    {
        public long GameId { get; set; }
        public string GameType { get; set; }
        public long GameStartTime { get; set; }
        public long MapId { get; set; }
        public long GameLength { get; set; }
        public string PlatformId { get; set; }
        public string GameMode { get; set; }
        public List<BannedChampion> BannedChampions { get; set; }
        public long GameQueueConfigId { get; set; }
        public Observer Observers { get; set; }
        public List<CurrentGameParticipant> Participants { get; set; }
        
        public Spectator()
        {
            
        }

    }
}