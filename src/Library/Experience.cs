using System;
using System.Collections.Generic;
namespace Library
{
    abstract class Experience
    {
        private int points;
        private int coins;
        private int travelersLimit;
        private List<Traveler> travelers = new List<Traveler>();

        public Experience(int points, int coins, int travelersLimit){
            this.points = points;
            this.coins = coins;
            this.travelersLimit = travelersLimit;
        }

        public void AddTraveler(Traveler trav)
        {
            if(this.travelers.Count == travelersLimit)
            {
                throw new Exception("To many travelers in this experience.");
            }
            else
            {
                this.travelers.Add(trav);
            }
        }
        abstract public void DoExperience(Traveler trav);
    }
}