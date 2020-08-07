using LoLAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLAPI.API
{
    public abstract class BuilderUrl
    {
        private static string Version = "v4";
        private GameEnum GameType { get; set; }

    }
}
