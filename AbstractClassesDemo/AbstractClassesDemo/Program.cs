using System;

namespace AbstractClassesDemo
{
    abstract class Animal
    {
        public int NumberOfLimbs { get; set; }

        public string Color { get; set; }

        public abstract void Breathe();

        public abstract void Eat();

        public abstract void Rest(); 

    }
}
