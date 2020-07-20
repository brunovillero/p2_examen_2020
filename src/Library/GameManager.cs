using System;
using System.Collections.Generic;
namespace Library
{
    public class GameManager
    {
        // Patron creator usado en esta clase, debido a que el juego 
        // utiliza de manera muy cercana las clases Station y Traveler

        // Ademas del principio de responsabilidad unica, la logica del manejo
        // del juego deberia ir aqui
        private List<Station> Stations {get; set;}
        private List<Traveler> Players {get; set;}
        public GameManager(List<Traveler> players)
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

            station_1.AddExperience(mountain);
            station_2.AddExperience(ocean);
            station_3.AddExperience(farm);
            station_4.AddExperience(thermalWaters);

            foreach (var traveler in players)
            {
                start.AddTraveler(traveler);
            }

            this.Players = players;
            this.Stations = new List<Station>{start, station_1, station_2, station_3, station_4, end};
        }

        public void MoveTravelerToStation(int wantedStationIndex, Traveler traveler){
            
            int currentIndex = -1;
            
            foreach (var station in this.Stations)
            {
                if(station.Travelers.Contains(traveler))
                {
                    currentIndex = this.Stations.IndexOf(station);
                    break;
                }
            }

            if(currentIndex == -1)
            {
                throw new Exception("Traveler not found.");
            }
            
            else if (wantedStationIndex <= currentIndex)
            {
                throw new Exception("Traveler already visited this station.");
            }
            
            else if(wantedStationIndex >= this.Stations.Count)
            {
                throw new Exception("Station not found.");
            }

            else
            {   
                foreach (var station in this.Stations)
                {
                    if(station.Travelers.Contains(traveler))
                    {
                        station.RemoveTraveler(traveler);
                    }
                }

                Station wantedStation = this.Stations[wantedStationIndex];
                wantedStation.AddTraveler(traveler);
                
                if((int)wantedStation.Type == 2)
                {
                    Traveler winner = this.TheWinnerIs();
                    Console.WriteLine("The winner is: " + winner.Name);
                }
            }
        }

        public Traveler TheWinnerIs()
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

        public void DoExperiencience(Traveler traveler)
        {
            foreach (var station in this.Stations)
            {
                if(station.Travelers.Contains(traveler))
                {
                    station.RealizeExperience(traveler);
                    break;
                }
            }
        }
    }
} 