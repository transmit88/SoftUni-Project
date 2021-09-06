using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            int totalPieces = width * high;
            int finalPieces = width * high;
            int totalTakePieces = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int takePieces = int.Parse(input);

                totalPieces -= takePieces;
                totalTakePieces += takePieces;

                if (totalPieces <= 0)
                {
                    finalPieces = width * high;
                    Console.WriteLine($"No more cake left! You need {totalTakePieces - finalPieces} pieces more.");
                    break;
                }

            }

            if (totalPieces > 0)
            {
                Console.WriteLine($"{finalPieces - totalTakePieces} pieces are left.");
            }
        }
    }
}
