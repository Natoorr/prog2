using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesDemo
{
    class Shark : Animal
    {
        public Shark()
        {
            NumberOfLimbs = 5;
        }
        public override void Breathe()
        {
            Console.WriteLine("shaaak breathe");
        }

        public override void Eat()
        {
            Console.WriteLine("shorkl eat");
        }

        public override void Rest()
        {
            Console.WriteLine("shark rest");
        }

        public void swim()
        {
            Console.WriteLine("shark swim swim shark");
        }

    }
}
