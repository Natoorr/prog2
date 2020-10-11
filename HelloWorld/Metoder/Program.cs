using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Write two numbers you would like to add together");
            var num1 = 0;
            Console.WriteLine("Write the first number you want to add");
            Console.ReadLine();

            var num2 = 0;
            Console.WriteLine("Write the second number you want to add");
            Console.ReadLine();

            Console.WriteLine(Add(num1, num2));

            string[] words = new string[5];
            Console.WriteLine("Write 5 words you want in reversed order");
            foreach (string i in words) { 
            Console.WriteLine("Write word " + (i+1) + " in the array");
            Console.ReadLine();
            }

            string[] reversedWords = reversedStringArray(words);
            foreach (string i in reversedWords) {
                Console.WriteLine();
            }

            

            int[] numbers = new int[5];
            Console.WriteLine("Write 5 numbers you want to know the largest and smallest number of");
            foreach (string i in words)
            {
                Console.WriteLine("Write number " + (i+1) + " in the array");
                Console.ReadLine();
            }

            Console.WriteLine("The largest and smallest numbers are" + largeSmall(numbers));

        }
        //a. En metod som tar in en lista av heltal och adderar samtliga tal sedan returnerar summan.
        static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        //b.En metod som tar in en lista av ord och skriver ut dem i omvänd ordning
        static string[] reversedStringArray (string[] words)
        {
            Array.Reverse(words);
            return words;
        }

        //c.En metod som tar in en lista av heltal sedan tar reda på det största och det minsta talet och returnera dem.
        static int[] largeSmall(int[] numArray)
        {
            
            int largest = numArray[0];
            int smallest = numArray[0];


            foreach(int i in numArray)
            {
                if (i > largest)
                {
                    largest = i;
                }

                if (i < smallest)
                {
                    largest = i;
                }

            }

            int[] largestSmallest = new int[2];

            largestSmallest[0] = largest;
            largestSmallest[0] = smallest;
            
            return largestSmallest;
            
        }

    }
}
