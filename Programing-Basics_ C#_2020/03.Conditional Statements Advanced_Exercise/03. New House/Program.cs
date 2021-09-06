using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            double countFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            if (typeOfFlowers == "Roses")
            {
                price = countFlowers * 5;
                if (countFlowers > 80)
                {
                    price -= price * 0.10;
                }

            }

            else if (typeOfFlowers == "Dahlias")
            {
                price = countFlowers * 3.80;

                if (countFlowers > 90)
                {
                    price -= price * 0.15;
                }
            }

            else if (typeOfFlowers == "Tulips")
            {
                price = countFlowers * 2.80;

                if (countFlowers > 80)
                {
                    price -= price * 0.15;
                }
            }

            else if (typeOfFlowers == "Narcissus")
            {
                price = countFlowers * 3;

                if (countFlowers < 120)
                {
                    price += price * 0.15;
                }
            }

            else if (typeOfFlowers == "Gladiolus")
            {
                price = countFlowers * 2.50;

                if (countFlowers < 80)
                {
                    price += price * 0.20;
                }
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeOfFlowers} and {budget - price:F2} leva left.");
            }

            else if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}
