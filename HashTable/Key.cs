using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Key
    {
        private double Long;
        private double Lat;

        public Key(double longitude, double lat)
        {
            this.Long = longitude;
            this.Lat = lat;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Long, Lat).GetHashCode();
        }
    }
}
