using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int num1 = 0;

            while (num1 < num)
            {
                int currentNum = int.Parse(Console.ReadLine());

                num1 += currentNum;
            }

            Console.WriteLine(num1);
        }
    }
}
