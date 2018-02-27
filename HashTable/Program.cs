﻿using System;
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
            var dictionary = new Dictionary<string, int>();
            dictionary["hej"] = 3;
            dictionary["sol"] = 1;
            dictionary["sol"]++;

            var dict = new HashDictionary<string, int>(3);
            dict["hej"] = 3;
            dict["sol"] = 1;
            dict["sol"]++;

            Console.WriteLine(dictionary.Count);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            return;
            string[] cities = System.IO.File.ReadAllLines("cities100000.txt");
            HashDictionary<GeoLocation<double>, City> hashDictionary = new HashDictionary<GeoLocation<double>, City>(10007);
            KeyValuePair<GeoLocation<double>, City> key = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10,10), new City("Tjenarey", 10,10,500000));
            KeyValuePair<GeoLocation<double>, City> valuePair = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10, 10), new City("Hejsan", 10.503287498, 20.324453168413547355465138541354653, 500000));
            KeyValuePair<GeoLocation<double>, City> keyValue = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10, 10), new City("Svensson", 115, 10, 500000));
            KeyValuePair<GeoLocation<double>, City> valueKey = new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(10, 10), new City("Lundsson", 20, -115, 500000));

            foreach (var city in cities)
            {
                string[] city_info = city.Split('\t');

                hashDictionary.Add(new KeyValuePair<GeoLocation<double>, City>(new GeoLocation<double>(Double.Parse(city_info[1]), Double.Parse(city_info[2])), new City(city_info[0], Double.Parse(city_info[1]), Double.Parse(city_info[2]), int.Parse(city_info[3]))));
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
        }
    }
}
