using System;
using System.Collections.Generic;
namespace Library
{
    class Station
    {
        public Experience Exp {get; private set;}
        public List<Traveler> Travelers {get; private set;}
        public StationType Type {get; private set;}
        public Station(StationType type)
        {
            this.Travelers = new List<Traveler>();
            this.Type = type;
        }
        public void addExperience(Experience exp)
        {
            this.Exp = exp;
        }

        public void addTraveler(Traveler trav)
        {
            this.Travelers.Add(trav);
        }

        public void realizeExperience(Traveler trav)
        {
            this.Exp.DoExperience(trav);
        }
    }
}