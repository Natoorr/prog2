using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Dog : Animal
    {
        public Dog()
        {
            NumberOfLimbs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eats");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog sleeps");
        }

    }
}
