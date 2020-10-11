using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Pet
    {
        public string _collar;
        public string _species;
        public string _name;

        public void Poop()
        {
            Console.WriteLine(_name + "is pooping.");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + "is sleeping.");

        }

    }
}
