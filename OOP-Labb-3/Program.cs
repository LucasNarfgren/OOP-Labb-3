//LUCAS NARFGREN SUT21
using System;

namespace OOP_Labb_3 
{
    class Program
    {
        static void Main(string[] args)
        {

            Teckning R = new Rektangel();
            Teckning C = new Cirkel();
            Teckning F = new Fyrkant();

            Console.WriteLine("Rektangel Area: {0}",R.Area());
            Console.WriteLine("Cirkel Area: {0}",C.Area());
            Console.WriteLine("Fyrkant Area: {0}",F.Area());

            Console.ReadKey();
            
        }
    }
}
