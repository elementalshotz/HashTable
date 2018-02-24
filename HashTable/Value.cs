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

        public void replace(C c) => replace(c, tuple.Item2, tuple.Item3, tuple.Item4);

        public void replace(C c, L l) => replace(c, l, tuple.Item3, tuple.Item4);

        public void replace(C c, L l, A a) => replace(c, l, a, tuple.Item4);

        public void replace(C c, L l, A a, P p)
        {
            tuple = new Tuple<C, L, A, P>(c, l, a, p);
        }
    }
}
