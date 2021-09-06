using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutFloors = int.Parse(Console.ReadLine());
            int coutRooms = int.Parse(Console.ReadLine());

            for (int f = coutFloors; f >= 1; f--)
            {
                for (int r = 0; r < coutRooms; r++)
                {
                    if (f == coutFloors)
                    {
                        Console.Write($"L{f}{r} ");
                    }

                    else
                    {

                        if (f % 2 == 0)
                        {
                            Console.Write($"O{f}{r} ");
                        }

                        else
                        {
                            Console.Write($"A{f}{r} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
