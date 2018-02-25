using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Value<City, Latitude, Longitude, Population>
    {
        Tuple<City, Latitude, Longitude, Population> tuple;

        public Value(City clap, Latitude latitude, Longitude longitude, Population population) => tuple = new Tuple<City, Latitude, Longitude, Population>(clap, latitude, longitude, population);

        public Tuple<City, Latitude, Longitude, Population> Tuple => tuple;

        public void update(City c) => update(c, tuple.Item2, tuple.Item3, tuple.Item4);
        public void update(Latitude l) => update(tuple.Item1, l, tuple.Item3, tuple.Item4);
        public void update(Longitude a) => update(tuple.Item1, tuple.Item2, a, tuple.Item4);
        public void update(Population p) => update(tuple.Item1, tuple.Item2, tuple.Item3, p);

        public void update(City c, Latitude l) => update(c, l, tuple.Item3, tuple.Item4);

        public void update(City c, Latitude l, Longitude a) => update(c, l, a, tuple.Item4);

        public void update(City c, Latitude l, Longitude a, Population p)
        {
            tuple = new Tuple<City, Latitude, Longitude, Population>(c, l, a, p);
        }
    }
}
