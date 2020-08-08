using System.Collections.Generic;

namespace LoLAPI.Classes.SubClasses 
{
    public class Message
    {
        public string Severity { get; set; }
        public string Updated_At { get; set; }
        public string Author { get; set; }
        public List<Translation> Translations { get; set; }
        public string Created_At { get; set; }
        public string Id { get; set; }
        public string Content { get; set; }

        public Message()
        {
            
        }
    }
}