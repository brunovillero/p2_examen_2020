using System;
namespace Library
{
    public class ThermalWaters : Experience
    {
        public ThermalWaters(int points, int coins, int travelersLimit) : base(points, coins, travelersLimit)
        {

        }

        override public void DoExperience(Traveler traveler)
        {
            traveler.Points += this.Points;
        }
    }
}