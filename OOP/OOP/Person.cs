using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        private string _name;
        public int _age;
        public Pet _pet;

        public Person()
        {

        }

        

        public string Name
        {
            get { return _name; }
            set { string _name = value; }
        }


        public void Eat()
        {
            Console.WriteLine(_name + "is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + "is sleeping.");
        }


        public void SayName(Person niklas)
        {
            Console.WriteLine(_name);
        }
    }
}
