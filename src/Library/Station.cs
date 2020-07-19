using System;
using System.Collections.Generic;
namespace Library
{
    class Station
    {
        public List<Experience> Experiences {get; set;}
        public List<Traveler> Travelers {get; set;}

        public void addExperience(Experience exp)
        {
            this.Experiences.Add(exp);
        }

        public void addTraveler(Traveler trav)
        {
            this.Travelers.Add(trav);
        }

        public void realizeExperience(Experience exp, Traveler trav)
        {
            exp.DoExperience(trav);
        }
    }
}