using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = Console.ReadLine();
            double totalSum = 0;

            while (sum != "NoMoreMoney")
            {
                double sumParse = double.Parse(sum);

                if (sumParse > 0)
                {
                    Console.WriteLine($"Increase: {sumParse:F2}");
                    totalSum += sumParse;
                    sum = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

            }
            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
