using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = System.IO.File.ReadAllLines("cities100000.txt");
            HashDictionary<GeoLocation, City> hashDictionary = new HashDictionary<GeoLocation, City>(10007);
            KeyValuePair<GeoLocation, City> key = new KeyValuePair<GeoLocation, City>(new GeoLocation(10,10), new City("Tjenarey", 10,10,500000));
            KeyValuePair<GeoLocation, City> valuePair = new KeyValuePair<GeoLocation, City>(new GeoLocation(10, 10), new City("Hejsan", 10.503287498, 20.324453168413547355465138541354653, 500000));
            KeyValuePair<GeoLocation, City> keyValue = new KeyValuePair<GeoLocation, City>(new GeoLocation(10, 10), new City("Svensson", 115, 10, 500000));
            KeyValuePair<GeoLocation, City> valueKey = new KeyValuePair<GeoLocation, City>(new GeoLocation(10, 10), new City("Lundsson", 20, -115, 500000));

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                hashDictionary.Add(new KeyValuePair<GeoLocation, City>(new GeoLocation(Double.Parse(city_info[1]), Double.Parse(city_info[2])), new City(city_info[0], Double.Parse(city_info[1]), Double.Parse(city_info[2]), int.Parse(city_info[3]))));
            }

            hashDictionary.Add(key);
            hashDictionary.Add(valuePair);
            hashDictionary.Add(keyValue);
            hashDictionary.Add(valueKey);

            foreach (var city in hashDictionary)
            {
                Console.WriteLine(city.Value.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Count: " + hashDictionary.Count);
            Console.WriteLine(hashDictionary.Contains(key));

            Console.WriteLine(hashDictionary.Find(key.Key));
            //Console.WriteLine(hashDictionary.Find(new GeoLocation<double>(101.05, 35.45)));

            hashDictionary.Clear();

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                hashDictionary[new GeoLocation(Double.Parse(city_info[1]), Double.Parse(city_info[2]))] = new City(city_info[0], Double.Parse(city_info[1]), Double.Parse(city_info[2]), int.Parse(city_info[3]));
            }

            GeoLocation location = new GeoLocation(100.45123, 50.5648);
            hashDictionary[location] = new City("Wat da hell", 100.45123, 50.5648, 500000);

            Thread.Sleep(3000);
            Console.Clear();

            foreach (var city in hashDictionary)
            {
                Console.WriteLine(city.Value.ToString());
            }

            Console.WriteLine(hashDictionary.Count);

            Console.WriteLine(hashDictionary[new GeoLocation(100.45123, 50.5648)]);

            hashDictionary[location] = new City("Wat da hell", 100.45123, 50.5648, 750000);

            Console.WriteLine(hashDictionary[location]);
        }
    }
}
