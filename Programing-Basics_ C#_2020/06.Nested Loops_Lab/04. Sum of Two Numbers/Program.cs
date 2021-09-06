using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finishtNum = int.Parse(Console.ReadLine());
            int magictNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool isFoud = false;

            for (int i = startNum; i <= finishtNum; i++)
            {
                for (int j = startNum; j <= finishtNum; j++)
                {
                    count++;

                    if (i + j == magictNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magictNum})");
                        isFoud = true;
                        break;
                    }

                }

                if (isFoud)
                {
                    break;
                }

            }

            if (!isFoud)
            {
                Console.WriteLine($"{count} combinations - neither equals {magictNum}");
            }
        }
    }
}
