﻿using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int elelemt = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += elelemt;
                }

                else
                {
                    oddSum += elelemt;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }

            else if (evenSum != oddSum)
            {
                sum = Math.Abs(evenSum - oddSum);

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum}");
            }
        }
    }
}
