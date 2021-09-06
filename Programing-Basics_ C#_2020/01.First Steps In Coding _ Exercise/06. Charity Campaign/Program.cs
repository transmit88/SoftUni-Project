using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesForDay = cakes * 45;
            double wafflesForDay = waffles * 5.80;
            double pancakesForDay = pancakes * 3.20;

            double sumForDay = (cakesForDay + wafflesForDay + pancakesForDay) * confectioners;

            double allSum = sumForDay * day;
            double costs = allSum - (allSum / 8);

            Console.WriteLine(costs);
        }
    }
}
