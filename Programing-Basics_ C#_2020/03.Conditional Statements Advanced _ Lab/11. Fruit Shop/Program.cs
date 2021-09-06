using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    number = number * 2.50;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "apple")
                {
                    number = number * 1.20;
                    Console.WriteLine($"{number:f2}");
                }

                else if (fruit == "orange")
                {
                    number = number * 0.85;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "graperfruit")
                {
                    number = number * 1.45;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "kiwi")
                {
                    number = number * 2.70;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "pineapple")
                {
                    number = number * 5.50;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "grapes")
                {
                    number = number * 3.85;
                    Console.WriteLine($"{number:F2}");
                }

                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    number = number * 2.70;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "apple")
                {
                    number = number * 1.25;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "orange")
                {
                    number = number * 0.90;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "grapefruit")
                {
                    number = number * 1.60;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "kiwi")
                {
                    number = number * 3;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "pineapple")
                {
                    number = number * 5.60;
                    Console.WriteLine($"{number:F2}");
                }

                else if (fruit == "grapes")
                {
                    number = number * 4.20;
                    Console.WriteLine($"{number:F2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
