using System.Collections.Generic;

namespace LoLAPI.Classes.SubClasses 
{
    public class Perks
    {
        public List<long> PerkIds { get; set; }
        public long PerkStyle { get; set; }
        public long PerkSubStyle { get; set; }

        public Perks()
        {
            
        }
    }
}