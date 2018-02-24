using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Key
    {
        private float Long;
        private float Lat;

        public Key(float longitude, float latitude)
        {
            this.Long = longitude;
            this.Lat = latitude;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Long, Lat).GetHashCode();
        }
    }
}
