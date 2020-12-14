using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Toy : Accessories
    {
        public Toy()
        {
            Cost = 15;
            Console.WriteLine("What size toy do you want?");
            Size = Console.ReadLine();
        }

        public override void Break()
        {
            Console.WriteLine("Toy broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The toy is cleaned");
        }
    }
}
