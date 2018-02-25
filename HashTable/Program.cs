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
            HashDictionary<GeoLocation<double>, City> hashDictionary = new HashDictionary<GeoLocation<double>, City>();
            KeyValuePair<GeoLocation<double>, City> key = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10,10), new City("Tjenarey", 10,10,500000));

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                hashDictionary.Add(new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(Double.Parse(city_info[1]), Double.Parse(city_info[2])), new City(city_info[0], Double.Parse(city_info[1]), Double.Parse(city_info[2]), int.Parse(city_info[3]))));
            }

            hashDictionary.Add(key);

            foreach (var city in hashDictionary)
            {
                Console.WriteLine(city.Value.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Count: " + hashDictionary.Count);
            Console.WriteLine(hashDictionary.Contains(key));
        }
    }
}
