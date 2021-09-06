using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string cyti = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());

            if (cyti == "Sofia")
            {
                if (sale >= 0 && sale <= 500)
                {
                    sale = (5 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 500 && sale <= 1000)
                {
                    sale = (7 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 1000 && sale <= 10000)
                {
                    sale = (8 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 10000)
                {
                    sale = (12 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (cyti == "Varna")
            {
                if (sale >= 0 && sale <= 500)
                {
                    sale = (4.5 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 500 && sale <= 1000)
                {
                    sale = (7.5 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 1000 && sale <= 10000)
                {
                    sale = (10 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 10000)
                {
                    sale = (13 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (cyti == "Plovdiv")
            {
                if (sale >= 0 && sale <= 500)
                {
                    sale = (5.5 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 500 && sale <= 1000)
                {
                    sale = (8 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 1000 && sale <= 10000)
                {
                    sale = (12 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
                }

                else if (sale > 10000)
                {
                    sale = (14.5 * sale) / 100;
                    Console.WriteLine($"{sale:F2}");
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
