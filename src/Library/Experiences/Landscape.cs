using System;
namespace Library
{
    abstract class Landscape : Experience
    {
        private int pointsMultiplier;

        public Landscape(int points, int coins, int travelersLimit, int pointsMultiplier) : base(points, coins, travelersLimit)
        {
            this.pointsMultiplier = pointsMultiplier;
        }

        override public void DoExperience(Traveler traveler)
        {

        }
    }
}