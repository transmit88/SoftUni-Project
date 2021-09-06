using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                num += num2;
            }

            Console.WriteLine(num);
        }
    }
}
