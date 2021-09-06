using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int numMax = int.MinValue;
            int numMin = int.MaxValue;

            for (int i = 0; i < counter; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (numMax < num)
                {
                    numMax = num;
                }

                if (numMin > num)
                {
                    numMin = num;
                }

            }

            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
        }
    }
}
