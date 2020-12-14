using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Food : Accessories
    {
        public Food()
        {
            Cost = 5;
            Console.WriteLine("What size food do you want?");
            Size = Console.ReadLine();
        }

        public override void Break()
        {
            Console.WriteLine("Food broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The food is cleaned");
        }
    }
}
