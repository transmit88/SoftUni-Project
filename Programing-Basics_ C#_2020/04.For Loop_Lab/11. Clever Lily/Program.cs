using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            double money = 0;
            double toys = 0;
            double toysMoney = 0;
            double bratherGetMoney = 0;
            double leftMoney = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    money += (i * 5);
                    bratherGetMoney += 1;
                }

                else
                {
                    toys += 1;
                }

            }

            toysMoney = toys * priceToy;
            leftMoney = money + toysMoney - bratherGetMoney;

            if (leftMoney >= priceLaundry)
            {
                Console.WriteLine($"Yes! {leftMoney - priceLaundry:F2}");
            }

            else
            {
                Console.WriteLine($"No! {priceLaundry - leftMoney:F2}");
            }
        }
    }
}
