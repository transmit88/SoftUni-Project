using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.40);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.80);

            double totalSumForRaspberies = raspberriesPrice * raspberries;
            double totalSumForOranges = oranges * orangesPrice;
            double totalBananasPrice = bananas * bananasPrice;
            double totalSumForStrawberries = strawberries * strawberriesPrice;

            double totalSum = totalSumForRaspberies + totalSumForOranges + totalBananasPrice + totalSumForStrawberries;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
