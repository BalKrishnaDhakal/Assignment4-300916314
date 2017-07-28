using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 22, 2017
 * Description: Assignment 4
 * Version: 0.2 Tested Habitable Method
*/
namespace Assignment4_300916314
{
    /// <summary>
    /// This is the Program(Driver) Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor", 138346.5, 987654321, "Gas");
            Console.WriteLine();
            Console.WriteLine(" ---GIANT PLANET---");
            Console.WriteLine(giantPlanet.ToString());
            giantPlanet.MoonCount = 67;
            giantPlanet.RingCount = 4;
            Console.WriteLine(" Name: " + giantPlanet.Name + " Number of Moon: " + giantPlanet.MoonCount + " Number of Rings: " + giantPlanet.RingCount);

            Console.WriteLine("====================================================\n");
            TerrestrialPlanet tereestrialPlanet = new TerrestrialPlanet("Mars", 123456.5, 123456789, true);
            tereestrialPlanet.MoonCount = 2;
            Console.WriteLine(" ---TERRESTRIAL PLANET---");
            Console.WriteLine(tereestrialPlanet.ToString());
            if (tereestrialPlanet.Habitable())
            {
                Console.WriteLine(tereestrialPlanet.Name + " is a Habitable Planet");

            }
            else
            {
                Console.WriteLine(tereestrialPlanet.Name + " is not a Habitable Planet");
            }

            Console.WriteLine( tereestrialPlanet.Name + " has " + tereestrialPlanet.MoonCount + " Moon ");

        }
    }
}
