using System;
using System.Collections.Generic;
namespace Library
{
    public abstract class Experience
    {
        public int Points {get; private set;}
        public int Coins {get; private set;}
        public int TravelersLimit {get; private set;}
        public Experience(int points, int coins, int travelersLimit){
            this.Points = points;
            this.Coins = coins;
            this.TravelersLimit = travelersLimit;
        }
        abstract public void DoExperience(Traveler trav);
    }
}