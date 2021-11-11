using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    class Teckning
    {

        public double _Pi { get; set; }

        public Teckning (double Pi = 3.14159265359)
        {
            this._Pi = Pi;
        }
        public virtual double Area()
        {
            return 0;
        }
    }
}
