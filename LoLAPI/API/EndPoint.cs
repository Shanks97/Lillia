using LoLAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI.API
{
    public abstract class EndPoint 
    {
        private static string _baseUrl = "https://{0}.api.riotgames.com/";
        public abstract GameEnum GameType { get; }

        public abstract int Version { get; }

        public abstract EndPointEnum EndPointType { get; }

        public virtual string GetBaseURL(RegionEnum region)
        {
            return 
                string.Format(_baseUrl, region.ToString())
                + GameType.ToString().Replace('_', '-') + "/" +
                EndPointType +  "/" ;
        }

    }
}
