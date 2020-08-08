using System.Collections.Generic;

namespace LoLAPI.Classes.SubClasses
{
    public class ParticipantTimeLine
    {
        public int ParticipantId { get; set; }
        public Dictionary<string,double> CSDiffPerMinDeltas { get; set; }
        public Dictionary<string,double> DamageTakenPerMinDeltas { get; set; }
        public string Role { get; set; }
        public Dictionary<string,double> DamageTakenDiffPerMinDeltas { get; set; }
        public Dictionary<string,double> XpPerMinDeltas { get; set; }
        public Dictionary<string,double> XpDiffPerMinDeltas { get; set; }
        public string Lane { get; set; }
        public Dictionary<string,double> CreepsPerMinDeltas { get; set; }
        public Dictionary<string,double> GoldPerMinDeltas { get; set; }

        public ParticipantTimeLine()
        {
            
        }



    }

}