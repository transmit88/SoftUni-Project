using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int day = 0;
            int spendDays = 0;

            while (true)
            {
                string text = Console.ReadLine();
                double curentMoney = double.Parse(Console.ReadLine());

                if (text == "save")
                {
                    money += curentMoney;
                    spendDays = 0;
                    day++;
                }

                else if (text == "spend")
                {
                    if (money - curentMoney < 0)
                    {
                        money = 0;
                    }

                    else
                    {
                        money -= curentMoney;
                    }

                    day++;
                    spendDays++;

                }

                if (spendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{day}");
                    break;
                }

                if (money >= needMoney)
                {
                    Console.WriteLine($"You saved the money for {day} days.");
                    break;
                }
            }
        }
    }
}
