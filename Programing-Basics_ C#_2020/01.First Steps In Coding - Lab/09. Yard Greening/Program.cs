using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double priceForLand = squareMeters * 7.61;
            double priceForLandDiscount = (0.18 * priceForLand);
            double totalPrice = (priceForLand - priceForLandDiscount);

            Console.WriteLine($"The final price is : {totalPrice:F2} lv.");
            Console.WriteLine($"The discount is : {priceForLandDiscount:F2} lv.");
        }
    }
}
