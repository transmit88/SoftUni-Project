using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double maxNum = double.MinValue;

            while (num != "Stop")
            {
                double numParse = double.Parse(num);
                if (numParse > maxNum)
                {
                    maxNum = numParse;
                }
                num = Console.ReadLine();

            }
            Console.WriteLine(maxNum);
        }
    }
}
