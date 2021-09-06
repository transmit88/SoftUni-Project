using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = rows * colums * 12;
                Console.WriteLine("{0:F2} leva", income);
            }

            else if (type == "Normal")
            {
                income = rows * colums * 7.50;
                Console.WriteLine("{0:F2} leva", income);
            }

            else if (type == "Discount")
            {
                income = rows * colums * 5;
                Console.WriteLine("{0:F2} leva", income);
            }
        }
    }
}
