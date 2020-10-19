using System;
using System.Security.Cryptography;
using System.Threading;

namespace UppgiftOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            string playerName;
            var buying = 0;

            Console.WriteLine("Type your name");
            playerName = Console.ReadLine();
            var you = new Customer(playerName);

            Console.WriteLine("Welcome to our store" + you.Name + "! Would you like to buy something?");

            bool isACustomer = false;
            
            
            Random rand = new Random();
            
            while (true) { 
            var randomNumber = rand.Next(1, 50);

                if (Console.ReadLine().ToLower() == "yes") {

                    Console.WriteLine("What would you like to buy?");
                    string productName = Console.ReadLine();

                    Console.WriteLine("How many would you like to buy? They cost " + randomNumber + " dollars each.");
                    int quantity =  Convert.ToInt32(Console.ReadLine());
                    var product = new Product(productName, randomNumber, quantity);
                    isACustomer = true;

                    Console.WriteLine("Would you like to buy anything else?");
                    if (Console.ReadLine().ToLower() == "yes")
                    {

                    } else
                    {
                        
                        break;
                    }
                }
            }

            Console.WriteLine("Do you want to view your cart?");
           
            if (Console.ReadLine().ToLower() == "yes") {
                
                foreach (var item in you._cart) {
                    
                    Console.WriteLine(item._name + ": Cost: " + item._totalCost);
                    
                    buying += item._totalCost;
                
                } 
            
            } else {
                
                foreach (var item in you._cart)
                {
                    buying += item._totalCost;
                }
                
                Console.WriteLine("Proceeding to checkout");
            
            }



            if (isACustomer)
            {
                Console.WriteLine("That will be " + buying + " dollars!");
            }

        }
    }
}
