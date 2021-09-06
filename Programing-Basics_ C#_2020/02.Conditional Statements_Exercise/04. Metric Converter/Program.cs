using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string unit = Console.ReadLine();

            if (text == "mm" && unit == "m")
            {
                num /= 1000;
                Console.WriteLine($"{num:F3}");
            }

            else if (text == "m" && unit == "cm")
            {
                num *= 100;
                Console.WriteLine($"{num:F3}");
            }

            else if (text == "cm" && unit == "mm")
            {
                num *= 10;
                Console.WriteLine($"{num:f3}");
            }

            else if (text == "cm" && unit == "m")
            {
                num /= 100;
                Console.WriteLine($"{num:F3}");
            }

            else if (text == "mm" && unit == "cm")
            {
                num /= 10;
                Console.WriteLine($"{num:F3}");
            }

            else if (text == "m" && unit == "mm")
            {
                num *= 1000;
                Console.WriteLine($"{num:F3}");
            }
        }
    }
}
