using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());

            double cakePrice = rentForHall * 20 / 100;
            double juicePrice = cakePrice - (cakePrice * 0.45);
            double animator = rentForHall / 3;

            double sum = rentForHall + cakePrice + juicePrice + animator;

            Console.WriteLine(sum);
        }
    }
}
