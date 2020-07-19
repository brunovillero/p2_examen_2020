using System;
using System.Collections.Generic;
namespace Library
{
    class Road
    {
        public List<Station> Stations {get; set;}
        public Road(List<Traveler> players)
        {
            // Build the road.
        }

        public void moveToStation(Station station,Traveler traveler){
            
            if(station.Travelers.Contains(traveler))
            {
                throw new Exception("Traveler already visited this station.");
            }
            else
            {
                station.addTraveler(traveler);
            }
        }
    }
} 