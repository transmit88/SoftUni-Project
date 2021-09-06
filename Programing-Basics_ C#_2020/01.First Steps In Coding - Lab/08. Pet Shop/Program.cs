using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double animalsFoodPrice = 4;
            double totalDogFoodPrice = dog * dogFoodPrice;
            double totalAnimalsFoodPrice = animals * animalsFoodPrice;
            double sum = totalDogFoodPrice + totalAnimalsFoodPrice;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
