using System;

namespace Library
{
    public class Traveler
    {
        // Patron Expert, Traveler es experto en su informacion
        public int Points {get; set;}
        public int Coins {get;  set;}
        public string Name {get; private set;}
        public Traveler(string name)
        {
            this.Points = 0;
            this.Coins = 0;
            this.Name = name;
        }
    }
}
