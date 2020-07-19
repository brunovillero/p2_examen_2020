using System;
using System.Collections.Generic;
namespace Library
{
    public class Station
    {
        public Experience Exp {get; private set;}
        public List<Traveler> Travelers {get; private set;}
        public StationType Type {get; private set;}
        public Station(StationType type)
        {
            this.Travelers = new List<Traveler>();
            this.Type = type;
        }
        public void AddExperience(Experience exp)
        {
            this.Exp = exp;
        }

        public void AddTraveler(Traveler trav)
        {
            if( (int)this.Type != 1)
            {
                this.Travelers.Add(trav);
            }
            else
            {
                if(this.Travelers.Count == this.Exp.TravelersLimit)
                {
                    throw new Exception("To many travelers in this experience.");
                }
                else
                {
                    this.Travelers.Add(trav);
                }
            }
        }

        public void RemoveTraveler(Traveler trav)
        {
            this.Travelers.Remove(trav);
        }

        public void RealizeExperience(Traveler trav)
        {
            this.Exp.DoExperience(trav);
        }
    }
}