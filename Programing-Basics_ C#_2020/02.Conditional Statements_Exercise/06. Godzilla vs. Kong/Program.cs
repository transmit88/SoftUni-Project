using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statist = double.Parse(Console.ReadLine());
            double priceClothing = double.Parse(Console.ReadLine());

            double sumDecor = budget * 0.10;
            double sumForClothing = statist * priceClothing;

            if (statist > 150)
            {
                sumForClothing -= sumForClothing * 0.10;
            }

            double totalSum = sumDecor + sumForClothing;

            if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - budget:F2} leva more.");
            }

            else if (totalSum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalSum:F2} leva left.");
            }
        }
    }
}
