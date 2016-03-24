using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Galactic_GPS
{
    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude,double longitude,Planet planet) : this()
        {

            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }
        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < 0 || value > 90)
                    throw new ArgumentOutOfRangeException("value","Cannot be negative or more than 90 degrees");
                this.latitude = value;
            } 
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < 0 || value>180)
                    throw new ArgumentOutOfRangeException("value", "Cannot be negative or more than 180 degrees");
                this.longitude = value;
            }
        
        }

        public Planet Planet { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",this.Latitude,this.Longitude,this.Planet);
        }
    }
}
