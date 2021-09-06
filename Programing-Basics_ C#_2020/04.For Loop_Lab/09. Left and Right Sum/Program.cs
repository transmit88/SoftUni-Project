using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
