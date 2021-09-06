using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double minNum = double.MaxValue;

            while (num != "Stop")
            {
                double numParse = double.Parse(num);

                if (numParse < minNum)
                {
                    minNum = numParse;
                }

                num = Console.ReadLine();

            }

            Console.WriteLine(minNum);
        }
    }
}
