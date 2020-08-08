using System;
using LoLAPI.Attributes;
using LoLAPI.Enums;

namespace LoLAPI.Classes
{
    [EndPoint(1, GameEnum.riot, EndPointEnum.account)]
    public class Account 
    {
        public string PuuId { get; set; }
        public string GameName { get; set; }
        public string TagLine { get; set; }

        public Account()
        {
            
        }

    }
}