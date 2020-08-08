using System;
using LoLAPI.Enums;

namespace LoLAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EndPointAttribute : Attribute
    {
        public int Version { get; set; }
        public GameEnum Game { get; set; }
        public EndPointEnum EndPointType { get; set; }
        public EndPointAttribute(int version, GameEnum game, EndPointEnum endP)
        {
            Version = version;
            Game = game;
            EndPointType = endP;
        }
    }
}