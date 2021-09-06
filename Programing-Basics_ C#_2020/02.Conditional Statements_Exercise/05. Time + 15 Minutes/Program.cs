using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double minplus15 = min + 15;

            if (minplus15 > 59)
            {
                minplus15 -= 60;
                hour += 1;
            }

            if (hour == 24)
            {
                hour = 0;
            }

            if (minplus15 < 10)
            {
                Console.WriteLine($"{hour}:0{minplus15}");
            }

            else
            {
                Console.WriteLine($"{hour}:{minplus15}");
            }
        }
    }
}
