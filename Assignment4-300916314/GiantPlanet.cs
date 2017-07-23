using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 22, 2017
 * Description: This is an GiantPlanet Class which inherits from the Planet Class
 * and implements the IHasMoons and IHasRings Interface
 * must be implemente in any class that subscribe to it 
 *Version:0.1 - Created GiantPlanet Class
 */
namespace Assignment4_300916314
{
    /// <summary>
    /// This is the GiantPlanet Class
    /// </summary>
    class GiantPlanet:Planet,IHasMoons,IHasRings
    {
        // PRIVATE INSTANCE VARIABLES
        private string _type;
        // PUBLIC PROPERTIES
        // CONSTRUCTORS
        /// <summary>
        /// This is a main constructors of GianPlanet Class
        /// It takes four arguments- name(string), diameter(double), mass(double), type(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
         : base(name, diameter, mass)
        {
            this._type = type;
        }

    }
}
