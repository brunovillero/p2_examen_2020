using System;
using System.Collections.Generic;
namespace Library
{
    abstract class Experience
    {
        public int Points {get; private set;}
        public int Coins {get; private set;}
        public int TravelersLimit {get; private set;}
        private List<Traveler> travelers;

        public Experience(int points, int coins, int travelersLimit){
            this.Points = points;
            this.Coins = coins;
            this.TravelersLimit = travelersLimit;
            this.travelers = new List<Traveler>();
        }

        public void AddTraveler(Traveler trav)
        {
            if(this.travelers.Count == this.TravelersLimit)
            {
                throw new Exception("To many travelers in this experience.");
            }
            else
            {
                this.travelers.Add(trav);
            }
        }

        public void IsTravelerAdded(Traveler trav)
        {
            if( ! this.travelers.Contains(trav))
            {
                throw new Exception("Traveler is not in this experience.");
            }
        }

        public void RemoveTraveler(Traveler trav)
        {
            if(this.travelers.Contains(trav))
            {
                this.travelers.Remove(trav);
            }
        }
        abstract public void DoExperience(Traveler trav);
    }
}