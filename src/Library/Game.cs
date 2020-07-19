using System;
using System.Collections.Generic;
namespace Library
{
    class Game
    {
        public List<Station> Stations {get; private set;}
        private List<Traveler> Players {get; set;}
        public Game(List<Traveler> players)
        {
            // Build the road.
            Experience mountain      = new Mountain(1, 0, 4);
            Experience ocean         = new Ocean(1, 0, 3);
            Experience farm          = new Farm(0, 3, 1);
            Experience thermalWaters = new ThermalWaters(2, 0, 2);

            Station start     = new Station((StationType)0);
            Station station_1 = new Station((StationType)1);
            Station station_2 = new Station((StationType)1);
            Station station_3 = new Station((StationType)1);
            Station station_4 = new Station((StationType)1);
            Station end       = new Station((StationType)2);

            station_1.addExperience(mountain);
            station_2.addExperience(ocean);
            station_3.addExperience(farm);
            station_4.addExperience(thermalWaters);

            foreach (var traveler in players)
            {
                this.MoveTravelerToStation(start, traveler);
            }

            this.Players = players;
            this.Stations = new List<Station>{station_1, station_2, station_3, station_4};
        }

        public void MoveTravelerToStation(Station station,Traveler traveler){
            
            if(station.Travelers.Contains(traveler))
            {
                throw new Exception("Traveler already visited this station.");
            }
            else
            {
                station.addTraveler(traveler);
                if((int)station.Type == 2)
                {
                    Traveler winner = this.TheWinnerIs();
                    Console.WriteLine("The winner is: " + winner.Name);
                }
            }
        }

        private Traveler TheWinnerIs()
        {
            Traveler winner = null;
            foreach (var traveler in this.Players)
            {
                if(winner == null)
                {
                    winner = traveler;
                }
                else if (traveler.Points > winner.Points)
                {
                    winner = traveler;
                }
            }

            return winner;
        }
    }
} 