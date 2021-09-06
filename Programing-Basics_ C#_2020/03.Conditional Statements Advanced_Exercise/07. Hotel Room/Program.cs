using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mouth = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            double totalPriceForStudio = 0;
            double totalPriceForApartment = 0;

            if (mouth == "May" || mouth == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                totalPriceForStudio = studioPrice * night;
                totalPriceForApartment = apartmentPrice * night;

                if (night > 7 && night <= 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.05;
                }

                else if (night > 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.30;
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            else if (mouth == "June" || mouth == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                totalPriceForStudio = studioPrice * night;
                totalPriceForApartment = apartmentPrice * night;

                if (night > 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.20;
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            else if (mouth == "July" || mouth == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;

                totalPriceForStudio = studioPrice * night;
                totalPriceForApartment = apartmentPrice * night;

                if (night > 14)
                {
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            Console.WriteLine($"Apartment: {totalPriceForApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceForStudio:F2} lv.");
        }
    }
}
