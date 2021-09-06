using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double dolls = double.Parse(Console.ReadLine());
            double teddyBears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double puzzlesSum = 2.60;
            double dollsSum = 3;
            double teddyBearsSum = 4.10;
            double minionsSum = 8.20;
            double trucksSum = 2;

            double sum = puzzles * puzzlesSum + dolls * dollsSum + teddyBears * teddyBearsSum
                + minions * minionsSum + trucks * trucksSum;
            double toySum = puzzles + dolls + teddyBears + minions + trucks;

            if (toySum >= 50)
            {
                sum = sum - (sum * 0.25);

            }
            double rent = sum - (sum * 0.10);

            if (rent >= excursionPrice)
            {
                rent = rent - excursionPrice;
                Console.WriteLine($"Yes! {rent:F2} lv left.");
            }
            else
            {
                double needMoney = excursionPrice - rent;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }
        }
    }
}
