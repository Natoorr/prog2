using System;

namespace UppgiftPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {

            string productName = string.Empty;
            var customer = new Customer();

            Console.WriteLine("Welcome to our store!");

            while (true)
            {
                
                Console.WriteLine("What do you want to buy ?\n1.Food\n2.Drink\n3.Toy");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nWhat type of Food would you like?");
                        var name1 = Console.ReadLine();
                        var food = new Food() {_name = name1 };
                        customer._cart.Add(food);
                        break;

                    case 2:
                        Console.WriteLine("\nWhat type of Drink would you like?");
                        var name2 = Console.ReadLine();
                        var drink = new Drink() {_name = name2 };
                        customer._cart.Add(drink);
                        break;
                    
                    case 3:
                        Console.WriteLine("\nWhat type of Toy would you like?");
                        var name3 = Console.ReadLine();
                        var toy = new Toy() {_name = name3 };
                        customer._cart.Add(toy);
                        break;
                    
                    default:
                        break;
                        
                }

                Console.WriteLine("\nWould you like to buy anything else");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    continue;
                } 
                else
                {
                    break;
                }
            }

            Console.WriteLine("\nDo you want to view your cart?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("\nThese are the items in your cart");
                foreach (var item in customer._cart)
                {
                    Console.WriteLine(item._name);
                }

            }

            Random rand = new Random();
            var randomNumber = rand.Next();
            Console.WriteLine("\nThat will be $" + randomNumber + "! Thank you for your patronage!");
        }
    }
}
