using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Write 5 names");
            
            for (int i=0; i < names.Length; i++)
            {
                Console.WriteLine("Write name " + (i+1));
                names[i] = Console.ReadLine();
            }
            Array.Reverse(names);
            for (int i = 0; i > names.Length; i++)
            {
                Console.WriteLine("Name " + (i+1) + " is " + names[i]);
            }
        }
    }
}