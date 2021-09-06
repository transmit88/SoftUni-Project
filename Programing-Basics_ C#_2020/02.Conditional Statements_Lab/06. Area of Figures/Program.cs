using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            if (text == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                double area = num1 * num1;
                Console.WriteLine($"{area:f3}");
            }
            else if (text == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double sum = num1 * num2;

                Console.WriteLine($"{sum:f3}");
            }
            else if (text == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double area = (num1 * Math.PI) * num1;

                Console.WriteLine($"{area:f3}");
            }
            else if (text == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = (length * height) / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
