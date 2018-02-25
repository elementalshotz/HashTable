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
            HashTable<Value<string, double, double, int>> hashSet = new HashTable<Value<string, double, double, int>>();
            Value<string, double, double, int>[] hashSet2 = new Value<string, double, double, int>[10];
            hashSet.Add(new Value<string, double, double, int>("Rio das Ostras", -22.52694, -41.945, 100000));
            hashSet.Add(new Value<string, double, double, int>("City of London", 51.51279, -0.09184, 7556900));
            hashSet.Add(new Value<string, double, double, int>("New York City", 40.71427, -74.00597, 8175133));
            hashSet.Add(new Value<string, double, double, int>("Tokyo", 35.6895, 139.69171, 8336599));
            hashSet.Add(new Value<string, double, double, int>("Shanghai", 31.22222, 121.45806, 22315474));
            
            Console.WriteLine(hashSet.ElementAt(2).Tuple.ToString());
            hashSet.ElementAt(2).update(8175134);

            Tuple<string, double, double, int> tuple = new Tuple<string,double,double,int>("Tjenna",10.5,20.5,10);

            Console.WriteLine(tuple.GetHashCode());

            hashSet.CopyTo(hashSet2, 2);

            Console.WriteLine($"IsReadOnly {hashSet.IsReadOnly}");

            if (hashSet.Remove(hashSet2.ElementAt(1)))
                Console.WriteLine("Object removed!");

            if (!hashSet.Remove(hashSet2.ElementAt(1)))
                Console.WriteLine("Object not found!");

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(hashSet.Contains(hashSet2.ElementAt(3)));
            Console.WriteLine(hashSet2.ElementAt(3).Tuple.ToString());
            Console.WriteLine(hashSet2.ElementAt(4).Tuple.ToString());
        }
    }
}
