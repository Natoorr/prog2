using StrategyPatternDemo.Strategy;
using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What president do you want to make the president again?\n1. Trump\n2. Obama\n3. JFK\n4. Lincoln");
                var operation = Console.ReadLine();
                double numberOne;
                double numberTwo;
                IPresidentStrategy strat;

                Console.WriteLine("Enter a number:");
                numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number:");
                numberTwo = Convert.ToInt32(Console.ReadLine());
                bool reset = false;

                switch (operation.ToLower())
                {
                    case "trump":
                        strat = new TrumpStrategy();
                        break;
                    case "obama":
                        strat = new ObamaStrategy();
                        break;
                    case "jfk":
                        strat = new JFKStrategy();
                        break;
                    case "lincoln":
                        strat = new LincolnStrategy();
                        break;
                    default:
                        Console.WriteLine("Please select a valid operation");
                        reset = true;
                        strat = new JFKStrategy();
                        break;
                }

                if (reset)
                {
                    continue;
                }

                var calc = new President(strat);
                calc.PresidentInterface(numberOne, numberTwo);

                Console.WriteLine("Do you wish to continue? 'y'/'n'");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
