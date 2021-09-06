using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int volum = width * length * height;
            bool hasVolume = true;

            while (command != "Done")
            {
                int box = int.Parse(command);

                volum -= box;

                if (volum < 0)
                {
                    hasVolume = false;
                    break;
                }

                command = Console.ReadLine();
            }

            if (hasVolume)
            {
                Console.WriteLine($"{volum} Cubic meters left.");
            }

            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volum)} Cubic meters more.");
            }
        }
    }
}
