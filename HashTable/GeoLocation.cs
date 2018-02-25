using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class GeoLocation<K>
    {
        private K Long;
        private K Lat;

        public GeoLocation(K longitude, K latitude)
        {
            this.Long = longitude;
            this.Lat = latitude;
        }

        public override int GetHashCode() =>  Tuple.Create(Long, Lat).GetHashCode();
    }
}
