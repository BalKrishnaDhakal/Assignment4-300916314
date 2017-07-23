using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 22, 2017
 * Description: Assignment 4
 * Version: 0.1 Created object to the GiantPlanet Class and TerrestrialPlanet Class 
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
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor", 138346.5, 8888, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet tereestrialPlanet = new TerrestrialPlanet("Mercury", 138346.5, 8888, true);
            Console.WriteLine(tereestrialPlanet.ToString());
        }
    }
}
