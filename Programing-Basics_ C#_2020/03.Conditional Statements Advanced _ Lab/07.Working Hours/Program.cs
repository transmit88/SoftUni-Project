using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 0 && hour < 24)
            {
                if (hour <= 10 && hour >= 18)
                {
                    Console.WriteLine("closed");
                }

                else if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }

                else if (hour >= 10 && hour <= 18 && day != "Sunday")
                {
                    Console.WriteLine("open");
                }

                else
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}
