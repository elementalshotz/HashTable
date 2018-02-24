using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Value<C, L, A, T>
    {
        Tuple<C, L, A, T> tuple;

        public Value(C c, L l, A a, T t)
        {
            tuple = new Tuple<C, L, A, T>(c, l, a, t);
        }

        public Tuple<C, L, A, T> Tuple
        {
            get => tuple;
        }
    }
}
