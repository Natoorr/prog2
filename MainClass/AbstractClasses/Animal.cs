using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Animal
    {
        public int NumberOfLimbs { get; set; }

        public string Color { get; set; }

        public abstract void Eat();

        public abstract void Sleep();

    }
}
