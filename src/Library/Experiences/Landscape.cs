using System;
using System.Collections.Generic;
namespace Library
{
    public abstract class Landscape : Experience
    {
        // Patron Polimorfismo existen varios tipos de Experience
        // Pero todas pueden ser agrupadas y utilizadas sin necesidad de
        // diferenciar el tipo

        // Uso el principio de substituion de liskov, cada objeto
        // del tipo Experience tiene una responsabilidad que no cambia
        // doExperience(), aun existiendo diferentes tipos

        // Patron Expert porque necesitaba saber cuantas veces el 
        // viajero visito este tipo de Experiencia

        public int BonusPoints {get; private set;}
        public List<Traveler> TravelersHistory {get; private set;}

        public Landscape(int points, int coins, int travelersLimit, int bonusPoints) : base(points, coins, travelersLimit)
        {
            this.TravelersHistory = new List<Traveler>();
            this.BonusPoints = bonusPoints;
        }

        override public void DoExperience(Traveler traveler)
        {
            traveler.Points += this.CalculatePoints(traveler);
            this.AddTravelerToHistory(traveler);
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