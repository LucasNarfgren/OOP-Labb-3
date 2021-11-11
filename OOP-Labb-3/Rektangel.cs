using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    class Rektangel : Teckning
    {
        public double _Height { get; set; }
        public double _Width { get; set; }

        public Rektangel(double Width= 5 ,double Height = 6)
        {
            this._Width = Width;
            this._Height = Height;
        }

        public override double Area()
        {
            double Area = _Height * _Width;
            return Area;
        }
    }
}
