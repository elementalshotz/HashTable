using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = System.IO.File.ReadAllLines("cities100000.txt");
            HashDictionary<GeoLocation<string>, City> hashDictionary = new HashDictionary<GeoLocation<string>, City>();

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                hashDictionary.Add(new KeyValuePair<GeoLocation<string>, City>(new GeoLocation<string>(city_info[1], city_info[2]), new City(city_info[0], Double.Parse(city_info[1]), Double.Parse(city_info[2]), int.Parse(city_info[3]))));
            }
        }
    }
}
