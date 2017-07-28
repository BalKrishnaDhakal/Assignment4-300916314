using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 21, 2017
 * Description: This is the Abstract Planet Class
 * Version: 0.2 - Created Constructor and ToString Method to Abstract Planet Class
 * Github Link: https://github.com/BalKrishnaDhakal/Assignment4-300916314
*/
namespace Assignment4_300916314
{
    /// <summary>
    /// This is the Abstract Planet Class
    /// </summary>
   public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        // PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;

            }
        }
        public string Name
        {
            get
            {
                return this._name;

            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for abstract Planet Class
        /// It takes three arguments - name(string),  diameter (double) and mass (double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet (string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        //PRIVATE METHODS
        // PUBLIC OVERRIDDEN METHODS
        /// <summary>
        /// Overridden the build in ToString method
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
             return string.Format(" Name:{0,5}, Diameter: {1,5},  Mass: {2,5}", Name, Diameter, Mass);
   
        }

    }
}
