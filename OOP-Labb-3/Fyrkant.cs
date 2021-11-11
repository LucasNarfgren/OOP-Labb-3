using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    

    class Fyrkant : Teckning
    {
        public double _Height { get; set; }

        public Fyrkant (double Height = 6)
        {
            this._Height = Height;
        }

        public override double Area()
        {
            double Area = _Height * _Height;
            return Area;
        }
    }
}
