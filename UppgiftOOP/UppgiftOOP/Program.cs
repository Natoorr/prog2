using System;
using System.Threading;

namespace UppgiftOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            int age;
            var buying = 0;

            Console.WriteLine("Write your name");
            name = Console.ReadLine();
            Console.WriteLine("Type your age"); 
            age = Convert.ToInt32(Console.ReadLine());
            
            Customer you = new Customer(name, age);
            Product apple = new Product("Apple", 5);
            Product orange = new Product("Orange", 7);
            Product banana = new Product("Banana", 10);

            Console.WriteLine("Welcome to our store " + you.Name + "! What would you like to buy?\n" + apple.Name + ", " + apple.Cost + " dollars\n" + orange.Name + ", " + orange.Cost + " dollars\n" + banana.Name + ", " + banana.Cost + " dollars");

            bool loopPurchase = true;
            while (loopPurchase) { 
                Console.WriteLine("(How many " + apple.Name + "s would you like to buy?)");
                int apples = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("(How many " + orange.Name + "s would you like to buy?)");
                int oranges = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("(How many " + banana.Name + "s would you like to buy?)");
                int bananas = Convert.ToInt32(Console.ReadLine());

                buying = apples * apple.Cost + oranges * orange.Cost + bananas * banana.Cost;
                you.CustomerBasket(apples, oranges, bananas);
                
                Console.WriteLine("(You are currently buying " + you.CallBasket() + " costing you " + buying + " dollars. Would you like to change anything?)");

                bool loopAnswer = true;
                while (loopAnswer)
                {
                    
                    string choice = Console.ReadLine();
                    
                    if (choice.ToLower() == "yes") 
                    { 
                        
                        loopAnswer = false; 
                    
                    } else if (choice.ToLower() == "no") {

                        loopPurchase = false;
                        loopAnswer = false;
                    
                    } else { 
                        
                        Console.WriteLine("Please write 'Yes' or 'No' "); 
                    
                    } 
                }


            }
            
            if (buying > 100 && you.Age < 10) {
                Console.WriteLine("You're too young to have " + buying + " dollars at hand! Get tha fuck outta here!");
                
            } 
            else 
            {
                Console.WriteLine("That will be " + buying + " dollars!");
            }

        }
    }
}
