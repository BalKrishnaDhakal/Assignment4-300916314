using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 22, 2017
 * Description: This is an TerrestrialPlanet Class which inherits from the Planet Class
 * and implements the IHasMoons and IHabitable Interface
 *Version:0.2 -  Implemented IHasMoons and IHabitable Interfaces
 * Github Link: https://github.com/BalKrishnaDhakal/Assignment4-300916314
 */
namespace Assignment4_300916314
{
    /// <summary>
    /// This is TerrestrialPlanet Class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;
        // PUBLIC PROPERTIES
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor of TerrestrialPlanet Class
        /// It takes four arguments -name(string), diameter(double), Mass(double), oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS
        // PUBLIC METHODS
        public bool HasMoons()
        {
            return (this.MoonCount > 0);
        }
        // PUBLIC METHODS
        public bool Habitable()
        {
            return (this._oxygen == true);
        }
    }
}
