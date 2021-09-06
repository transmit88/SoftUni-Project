using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double buget = double.Parse(Console.ReadLine());

                double savedMoney = 0;

                while (savedMoney < buget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;

                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
