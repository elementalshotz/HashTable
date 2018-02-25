using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Key<K>
    {
        private K Long;
        private K Lat;

        public Key(K longitude, K latitude)
        {
            this.Long = longitude;
            this.Lat = latitude;
        }

        public override int GetHashCode() =>  Tuple.Create(Long, Lat).GetHashCode();
    }
}
