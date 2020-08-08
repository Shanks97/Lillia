using System;
using LoLAPI.Attributes;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(1, GameEnum.lol, EndPointEnum.clash)]
    public class Clash
    {
        public string SummonerId { get; set; }
        public string TeamId { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }

        public Clash()
        {
            
        }
    }
}