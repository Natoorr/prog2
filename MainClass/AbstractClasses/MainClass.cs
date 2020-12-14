using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            var dog = new Dog();
            dog.Color = "Brown";

            var cat = new Cat();
            cat.Color = "Black";

            var bird = new Bird();
            bird.Color = "Green";


            animals.Add(dog);
            animals.Add(cat);
            animals.Add(bird);

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Sleep();
            }


            List<Accessories> accessories = new List<Accessories>();

            var leash = new Leash();
            leash.Size = "Red";

            var food = new Food();
            food.Size = "Blue";

            var toy = new Toy();
            toy.Size = "Green";


            animals.Add(dog);
            animals.Add(cat);
            animals.Add(bird);

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Sleep();
            }
            
            foreach (var accessoy in accessories)
            {
                accessories.Break();
                accessories.Clean();
            }
        }

    }
}
