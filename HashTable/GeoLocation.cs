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

        public K Latitude
        {
            get => Lat;
        }

        public K Longitude
        {
            get => Long;
        }

        public override int GetHashCode() => Tuple.Create(Long, Lat).GetHashCode();

        public override string ToString()
        {
            return $"Lat: {Lat} \t Long {Long}";
        }
    }
}
