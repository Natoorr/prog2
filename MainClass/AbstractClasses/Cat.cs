using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Cat : Animal
    {
        public Cat()
        {
            NumberOfLimbs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Cat eats");
        }

        public override void Sleep()
        {
            Console.WriteLine("Cat sleeps");
        }
    }
}
