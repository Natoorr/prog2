using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Bird : Animal
    {
        public Bird()
        {
            NumberOfLimbs = 2;
        }

        public override void Eat()
        {
            Console.WriteLine("Bird eats");
        }

        public override void Sleep()
        {
            Console.WriteLine("Bird sleeps");
        }
    }
}
