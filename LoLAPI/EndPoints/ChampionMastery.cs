using LoLAPI.API;
using LoLAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI.EndPoints
{
    public class ChampionMastery : IEndPoint
    {
        public override GameEnum Game => GameEnum.lol;

        public override int Version => 4;

        public override EndPointEnum EndPointType => EndPointEnum.champion_mastery;
    }
}
