using System.Collections.Generic;

namespace LoLAPI.Classes.SubClasses
{
    public class Service
    {
       public List<Incident> Incidents { get; set; }
       public string Name { get; set; }
       public string Slug { get; set; }
       public string Status { get; set; }

       public Service()
       {
           
       }

    }
}