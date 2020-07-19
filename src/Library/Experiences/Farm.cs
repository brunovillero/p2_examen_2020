using System;
namespace Library
{
    class Farm : Experience
    {
        public Farm(int points, int coins, int travelersLimit) : base(points, coins, travelersLimit)
        {

        }

        override public void DoExperience(Traveler traveler)
        {
            try
            {
                this.IsTravelerAdded(traveler);
                traveler.Coins += this.Coins;
            }
            catch (System.Exception e)
            {
                throw e;
            } 
        }
    }
}