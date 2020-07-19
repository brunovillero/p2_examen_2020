using System;
using System.Collections.Generic;
namespace Library
{
    abstract class Landscape : Experience
    {
        public int BonusPoints {get; private set;}
        public List<Traveler> TravelersHistory {get; private set;}

        public Landscape(int points, int coins, int travelersLimit, int bonusPoints) : base(points, coins, travelersLimit)
        {
            this.TravelersHistory = new List<Traveler>();
            this.BonusPoints = bonusPoints;
        }

        override public void DoExperience(Traveler traveler)
        {
            try
            {
                this.IsTravelerAdded(traveler);
                traveler.Points += this.CalculatePoints(traveler);
                this.AddTravelerToHistory(traveler);
            }
            catch (System.Exception e)
            {
                throw e;
            } 
        }

        public void AddTravelerToHistory(Traveler traveler)
        {
            this.TravelersHistory.Add(traveler);
        }

        public int CalculatePoints(Traveler traveler){
            int result = this.Points;

            foreach (var item in this.TravelersHistory)
            {
                if(item == traveler)
                {
                    result += this.BonusPoints;
                }
            }

            return result;
        }
    }
}