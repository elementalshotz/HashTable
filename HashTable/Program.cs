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
            HashSet<int> hashSet = new HashSet<int>();
            int[] hashSet2 = new int[10];
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(4);
            hashSet.Add(5);

            


            hashSet.CopyTo(hashSet2, 2);

            if (hashSet.Remove(4))
                Console.WriteLine("Object removed!");

            if (!hashSet.Remove(700))
                Console.WriteLine("Object not found!");

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(hashSet.Contains(3));
            Console.WriteLine(hashSet2.ElementAt(1));
        }
    }
}
