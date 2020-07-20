using System;
using System.Collections.Generic;
namespace Library
{
    public abstract class Experience
    {
        // Patron Expert, la clase Experience es experta en
        // Conoce sus puntos, monedas y limite de travelers
        // Ademas de otorgarle experiencia al traveler

        // Patron Polimorfismo existen varios tipos de Experience
        // Pero todas pueden ser agrupadas y utilizadas sin necesidad de
        // diferenciar el tipo

        // Uso el principio de substituion de liskov, cada objeto
        // del tipo Experience tiene una responsabilidad que no cambia
        // doExperience(), aun existiendo diferentes tipos
        public int Points {get; private set;}
        public int Coins {get; private set;}
        public int TravelersLimit {get; private set;}
        public Experience(int points, int coins, int travelersLimit)
        {
            this.Points = points;
            this.Coins = coins;
            this.TravelersLimit = travelersLimit;
        }
        abstract public void DoExperience(Traveler trav);
    }
}