using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int aquarium = length * width * height;
            double litersAquarium = aquarium * 0.001;
            double percentLiters = percent * 0.01;

            double totalLiters = litersAquarium - (litersAquarium * percentLiters);

            Console.WriteLine(totalLiters);
        }
    }
}
