﻿using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * quantity);
                }

                else if (product == "water")
                {
                    Console.WriteLine(0.80 * quantity);
                }

                else if (product == "beer")
                {
                    Console.WriteLine(1.20 * quantity);
                }

                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }

                else if (product == "peanuts")
                {
                    Console.WriteLine(1.60 * quantity);
                }

            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.40 * quantity);
                }

                else if (product == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }

                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }

                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * quantity);
                }

                else if (product == "peanuts")
                {
                    Console.WriteLine(1.50 * quantity);
                }

            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }

                else if (product == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }

                else if (product == "beer")
                {
                    Console.WriteLine(1.10 * quantity);
                }

                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }

                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }
}
