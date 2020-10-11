using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person niklas = new Person();
            niklas.Name = "Niklas";
            niklas._age = 33;
            niklas.Eat();
            niklas.Sleep();


            Pet smulan = new Pet();
            smulan._name = "Cooling";
            smulan._species = "Orangutang";
            smulan._collar = "purple";

            niklas._pet = smulan;

            niklas.SayName(niklas);


        }

        
    }

}
