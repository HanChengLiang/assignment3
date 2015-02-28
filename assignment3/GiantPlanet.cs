using System;
using System.Collections.Generic;
//Han Cheng Liang
//300791705
//A program to calculate the diameter of mars and earth
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Planet
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //private instance variables 
        private string _type;

        //Constuctor

        // takes a name, mass diameter and type
        public GiantPlanet(string name, double mass, double diameter, string type) :
            base(name, mass, diameter)
        {
            this._type = type;
        }


        public bool HasMoons()
        {
            return this.MoonCount > 0 ? true : false;
        }

        public bool HasRings()
        {
            return this.RingCount > 0 ? true : false;
        }
    }
}