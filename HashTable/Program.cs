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
            

            HashDictionary<Key<float>, Value<string, float, float, int>> hashDictionary = new HashDictionary<Key<float>, Value<string, float, float, int>>();
            hashDictionary.Add(new KeyValuePair<Key<float>, Value<string, float, float, int>>(new Key<float>((float)10.5, (float)20.5), new Value<string, float, float, int>("Vasteras", (float)10.5, (float)20.5, 5000)));
        }
    }
}
