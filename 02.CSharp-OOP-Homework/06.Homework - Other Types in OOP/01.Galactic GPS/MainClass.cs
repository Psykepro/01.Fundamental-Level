using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Galactic_GPS
{
    class MainClass
    {
        static void Main()
        {
            Location mars=new Location(24.45,39.2,Planet.Mars);
            Console.WriteLine(mars);
        }
    }
}
