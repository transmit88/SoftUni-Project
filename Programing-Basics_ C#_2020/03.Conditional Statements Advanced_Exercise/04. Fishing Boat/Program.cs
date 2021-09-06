using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishCounter = double.Parse(Console.ReadLine());

            double shipPrice = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
                case "Summer":
                    shipPrice = 4200;
                    break;
            }

            if (fishCounter <= 6)
            {
                discount = shipPrice * 0.10;
            }

            else if (fishCounter > 6 && fishCounter <= 11)
            {
                discount = shipPrice * 0.15;
            }

            else if (fishCounter >= 12)
            {
                discount = shipPrice * 0.25;
            }

            if (fishCounter % 2 == 0 && season != "Autumn")
            {
                discount += (shipPrice - discount) * 5 / 100;
            }

            double totalSum = shipPrice - discount;
            double leaveMoney;

            if (budget >= totalSum)
            {
                leaveMoney = budget - totalSum;
                Console.WriteLine($"Yes! You have {leaveMoney:F2} leva left.");
            }

            else if (budget < totalSum)
            {
                leaveMoney = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {leaveMoney:F2} leva.");
            }
        }
    }
}
