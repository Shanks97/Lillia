using LoLAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI.API
{
    public interface IEndPoint 
    {
        private static string _baseUrl = "https://{0}.api.riotgames.com/";
        public abstract GameEnum Game { get; }

        public abstract int Version { get; }

        public abstract EndPointEnum EndPointType { get; }

        public virtual string GetBaseURL(RegionEnum region)
        {
            return 
                string.Format(_baseUrl, region.ToString())
                + Game.ToString().Replace('_', '-') + "/" +
                EndPointType +  "/" ;
        }

    }

    public interface Da
    {
       public static string A { get; set; }
    }
}
