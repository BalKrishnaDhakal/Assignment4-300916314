using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 22, 2017
 * Description: This is an TerrestrialPlanet Class which inherits from the Planet Class
 * and implements the IHasMoons and IHabitable Interface
 *Version:0.1 -  Created TerrestrialPlanet Class
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
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS
        // PUBLIC METHODS
    }
}
