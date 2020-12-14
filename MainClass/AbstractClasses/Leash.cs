using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Leash : Accessories
    {
        public Leash()
        {
            Cost = 30;
            Console.WriteLine("What size leash do you want?");
            Size = Console.ReadLine();
        }

        public override void Break()
        {
            Console.WriteLine("Leash broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The leash is cleaned");
        }
    }
}
