using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Value<C, L, A, P>
    {
        Tuple<C, L, A, P> tuple;

        public Value(C c, L l, A a, P p)
        {
            tuple = new Tuple<C, L, A, P>(c, l, a, p);
        }

        public Tuple<C, L, A, P> Tuple
        {
            get => tuple;
        }
    }
}
