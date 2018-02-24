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
            HashSet<Value<string, float, float, int>> hashSet = new HashSet<Value<string, float, float, int>>();
            Value<string, float, float, int>[] hashSet2 = new Value<string, float, float, int>[10];
            hashSet.Add(new Value<string, float, float, int>("", (float)10.5, (float)20.5, 500));
            hashSet.Add(new Value<string, float, float, int>("", (float)10.5, (float)20.5, 500));
            hashSet.Add(new Value<string, float, float, int>("", (float)10.5, (float)20.5, 500));
            hashSet.Add(new Value<string, float, float, int>("", (float)10.5, (float)20.5, 500));
            hashSet.Add(new Value<string, float, float, int>("", (float)10.5, (float)20.5, 500));

            Tuple<string, double, double, int> tuple = new Tuple<string,double,double,int>("Tjenna",10.5,20.5,10);

            Console.WriteLine(tuple.GetHashCode());

            hashSet.CopyTo(hashSet2, 2);

            if (hashSet.Remove(4))
                Console.WriteLine("Object removed!");

            if (!hashSet.Remove(700))
                Console.WriteLine("Object not found!");

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(hashSet.Contains(3));
            Console.WriteLine(hashSet2.ElementAt(4));
        }
    }
}
