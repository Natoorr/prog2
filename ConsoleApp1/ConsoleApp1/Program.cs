using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;

            for (int tal = 4; tal < 10; tal++)
                summa = summa + tal;
            Console.WriteLine(summa);

        }
    }
}
