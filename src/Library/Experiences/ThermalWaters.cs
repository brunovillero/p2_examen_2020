using System;
namespace Library
{
    class ThermalWaters : Experience
    {
        public ThermalWaters(int points, int coins, int travelersLimit) : base(points, coins, travelersLimit)
        {

        }

        override public void DoExperience(Traveler traveler)
        {
            try
            {
                this.IsTravelerAdded(traveler);
                traveler.Points += this.Points;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}