using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class City
    {
        private string Name;
        private double Longitude;
        private double Latitude;
        private int Population;

        public City(string name, double longitude, double latitude, int population)
        {
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
            Population = population;
        }

        public bool Equals(City city)
        {
            return this.Name == city.Name && this.Longitude == city.Longitude && this.Latitude == city.Latitude && this.Population == city.Population;

        }
    }
}
