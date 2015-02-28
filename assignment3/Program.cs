using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Planet
{
    class Program
    {
        static void Main(string[] args)
        {   
            //caculation of mars
            GiantPlanet gianPlanet = new GiantPlanet("Mars", 639E21, 6779, "Terrestrial");
            Console.WriteLine(gianPlanet.ToString());

            //calculation of earth
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 5.972E24, 12742, true);
            Console.WriteLine(terrestrialPlanet.ToString());

        }
    }
}