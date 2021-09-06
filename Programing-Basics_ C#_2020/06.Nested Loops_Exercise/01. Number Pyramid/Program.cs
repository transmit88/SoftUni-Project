using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{current} ");

                    if (current >= n)
                    {
                        isBigger = true;
                        break;
                    }

                    current++;
                }

                Console.WriteLine();

                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}
