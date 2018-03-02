using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class GeoLocation
    {
        private double Long;
        private double Lat;

        public GeoLocation(double longitude, double latitude)
        {
            this.Long = longitude;
            this.Lat = latitude;
        }

        public double Latitude
        {
            get => Lat;
        }

        public double Longitude
        {
            get => Long;
        }

        public override int GetHashCode() => (int)Math.Abs(Math.Pow(Long, Lat));

        public override string ToString()
        {
            return $"Lat: {Lat} \t Long {Long}";
        }
    }
}
