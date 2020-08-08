using System.Collections.Generic;

namespace LoLAPI.Classes.SubClasses
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public int ChampionId { get; set; }
        public List<Rune> Runes { get; set; }
        public ParticipantStats Stats { get; set; }
        public int TeamId { get; set; }
        public ParticipantTimeLine TimeLine { get; set; }
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        public string HighstAchievedSeasonTier { get; set; }
        public List<Mastery> Masteries { get; set; }

        public Participant()
        {
            
        }

    }

}