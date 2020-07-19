using System;
namespace Library
{
    public class Farm : Experience
    {
        public Farm(int points, int coins, int travelersLimit) : base(points, coins, travelersLimit)
        {

        }

        override public void DoExperience(Traveler traveler)
        {
            traveler.Coins += this.Coins;
        }
    }
}