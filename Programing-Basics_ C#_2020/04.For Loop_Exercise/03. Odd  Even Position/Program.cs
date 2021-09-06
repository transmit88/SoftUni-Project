﻿using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= counter; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                }

                else
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                }

            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }

            else
            {
                Console.WriteLine("OddMin=No,");
            }

            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }

            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }

            else
            {
                Console.WriteLine("EvenMin=No,");
            }

            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }

            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
