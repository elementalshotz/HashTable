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
            HashDictionary<GeoLocation<double>, City> hashDictionary = new HashDictionary<GeoLocation<double>, City>(50);
            KeyValuePair<GeoLocation<double>, City> key = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10,10), new City("Tjenarey", 10,10,500000));
            KeyValuePair<GeoLocation<double>, City> valuePair = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10.5032, 20.3244), new City("Hejsan", 10.5032, 20.3244, 500000));
            KeyValuePair<GeoLocation<double>, City> keyValue = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(115, 10), new City("Svensson", 115, 10, 500000));
            KeyValuePair<GeoLocation<double>, City> valueKey = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(20, -115), new City("Lundsson", 20, -115, 500000));

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                string cityName = city_info[0];
                double cityLongitude = Double.Parse(city_info[1]);
                double cityLatitude = Double.Parse(city_info[2]);
                int cityPopulation = Int32.Parse(city_info[3]);

                GeoLocation<double> geoLocation = new GeoLocation<double>(cityLongitude, cityLatitude);
                City value = new City(cityName, cityLongitude, cityLatitude, cityPopulation);
                KeyValuePair<GeoLocation<double>, City> cityKeyValuePair = new KeyValuePair<GeoLocation<double>, City>(geoLocation, value);

                hashDictionary.Add(cityKeyValuePair);
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

            City city1;
            Console.WriteLine(hashDictionary.TryGetValue(key.Key, out city1));
            //Console.WriteLine(hashDictionary.Find(new GeoLocation<double>(101.05, 35.45)));

            KeyValuePair<GeoLocation<double>, City>[] ctx = new KeyValuePair<GeoLocation<double>, City>[hashDictionary.Count];
            hashDictionary.CopyTo(ctx, 0);

            Console.WriteLine(ctx[0].Value.ToString());

            hashDictionary.Clear();

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                string cityName = city_info[0];
                double cityLongitude = Double.Parse(city_info[1]);
                double cityLatitude = Double.Parse(city_info[2]);
                int cityPopulation = Int32.Parse(city_info[3]);

                GeoLocation<double> geoLocation = new GeoLocation<double>(cityLongitude, cityLatitude);
                City value = new City(cityName, cityLongitude, cityLatitude, cityPopulation);

                hashDictionary[geoLocation] = value;
            }

            GeoLocation<double> location = new GeoLocation<double>(100.45123, 50.5648);

            double longitude = Double.Parse("100,45123");
            double latitude = Double.Parse("50,5648");
            City test = new City("Test city", longitude, latitude, 500000);

            hashDictionary[location] = test;

            Thread.Sleep(3000);
            Console.Clear();

            foreach (var city in hashDictionary)
            {
                Console.WriteLine(city.Value.ToString());
            }

            Console.WriteLine(hashDictionary.Count);

            Console.WriteLine(hashDictionary[location]);

            test.CityPopulation = 750000;
            hashDictionary[location] = test;

            Console.WriteLine(hashDictionary[location]);
        }
    }
}
