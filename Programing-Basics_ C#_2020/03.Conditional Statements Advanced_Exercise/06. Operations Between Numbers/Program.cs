using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();


            if ((symbol == "/" || symbol == "%") && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }

            else if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                int sum = 0;

                if (symbol == "+")
                {
                    sum = n1 + n2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - odd");
                    }
                }

                else if (symbol == "-")
                {
                    sum = n1 - n2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - odd");
                    }
                }

                else if (symbol == "*")
                {
                    sum = n1 * n2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {sum} - odd");
                    }
                }

            }

            else if (symbol == "/")
            {
                double sum = 1.00 * n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {sum:F2}");
            }

            else if (symbol == "%")
            {
                Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
            }
        }
    }
}
