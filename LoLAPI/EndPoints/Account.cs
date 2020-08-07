using LoLAPI.API;
using LoLAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI.EndPoints
{
    public class Account : EndPoint
    {
        public override GameEnum GameType => GameEnum.riot;

        public override int Version => 1;

        public override EndPointEnum EndPointType => EndPointEnum.account;
    }
}
