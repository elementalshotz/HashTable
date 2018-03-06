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
        private GeoLocation<double> location;
        private int Population;

        public City(string name, double longitude, double latitude, int population)
        {
            Name = name;
            location = new GeoLocation<double>(longitude, latitude);
            Population = population;
        }

        public bool Equals(City city)
        {
            return this.Name == city.Name && this.location.Latitude == city.location.Latitude && this.location.Longitude == city.location.Longitude && this.Population == city.Population;
        }

        public override string ToString()
        {
            return $"Name: {Name} \t Longitude: {location.Longitude} \t Latitude: {location.Latitude} \t Population: {Population}";
        }

        public string CityName
        {
            get => Name;
            set => Name = value;
        }

        public GeoLocation<double> GeoLocation
        {
            get => location;
            set => location = value;
        }

        public int CityPopulation
        {
            get => Population;
            set => Population = value;
        }
    }
}
