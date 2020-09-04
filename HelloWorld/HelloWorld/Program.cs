using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            bool aliveBool = true;

            Console.WriteLine("Are you alive?");
            string alive = Console.ReadLine();
            if (alive == "yes")
            {
                aliveBool = true;
            }
            else { aliveBool = false; }


            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            if (aliveBool = true)
            {

                Console.WriteLine("You are alive");

            }
            else
            {

                Console.WriteLine("You are not alive");
            }


            if (age >= 18 && aliveBool == true)
            {
                Console.WriteLine("You can buy alcohol");

            }
            else if (aliveBool == false)
            {
                Console.WriteLine("Dead people can't buy alcohol");

            }
            else
            {
                Console.WriteLine("You are too young to buy alcohol");
            }
            Console.WriteLine("Counting from 1 to your age");
            for (var i = 0; i < age; i++)
            {
                Console.WriteLine(i + 1);
            }

            string yes = "no";
            while (yes != "Yes")
            {
                Console.WriteLine("Write 'Yes'");
                yes = Console.ReadLine();
            }

            Console.WriteLine("Skriv in ett nummer mellan 1 och 3");
            int hello = Convert.ToInt32(Console.ReadLine());
            switch (hello)
            {
                case 1:
                    Console.WriteLine("One is the loneliest number that you'll ever do");
                    break;
                case 2:
                    Console.WriteLine("Two can be as bad as one, it's the loneliest number since the number one");
                    break;
                case 3:
                    Console.WriteLine("3 är dåligt nummer");
                    break;
                default:
                    Console.WriteLine("Din psykopat du följde inte instruktionerna");
                    break;
            }
        }
    }
}