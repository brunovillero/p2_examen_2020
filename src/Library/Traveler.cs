using System;

namespace Library
{
    public class Traveler
    {
        public int Points {get; set;}
        public int Coins {get;  set;}

        public Traveler(int points, int coins)
        {
            this.Points = points;
            this.Coins = coins;
        }
    }
}
