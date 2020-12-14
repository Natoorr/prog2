using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesDemo
{
    class Dog : Animal
    {
        public Dog()
        {
            NumberOfLimbs = 4;
        }
        public override void Breathe()
        {
            Console.WriteLine("Dog breathe");
        }

        public override void Eat()
        {
            Console.WriteLine("dog eat");
        }

        public override void Rest()
        {
            Console.WriteLine("dog rest");
        }

    }
}
