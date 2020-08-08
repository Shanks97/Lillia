using System;
using System.Collections.Generic;
using LoLAPI.Attributes;
using LoLAPI.Classes.SubClasses;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(3, GameEnum.lol, EndPointEnum.status)]
    public class LolStatus 
    {
        public List<string> Locales { get; set; }
        public string HostName { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }//TODO: Dto
        public string Slug { get; set; }
        public string Region_Tag { get; set; }

        public LolStatus()
        {
            
        }
    }
}