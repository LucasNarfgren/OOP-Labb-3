using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    class Cirkel : Teckning
    {
        public double _Radius { get; set; }

        public Cirkel (double Radius = 5)
        {
            this._Radius = Radius;
        }

        public override double Area()
        {
            double Area = Math.Pow(_Radius,2) * Math.PI;
            return Area;
        }
    }
}
