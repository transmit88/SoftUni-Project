using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = 0;
            double discount = 0;
            double totalPrice ;

            if (day < 10)
            {
                if (room == "room for one person")
                {
                    day -= 1;
                    price = 18 * day;
                    Console.WriteLine($"{price:F2}");
                }

                else if (room == "apartment")
                {
                    day -= 1;
                    price = 25 * day;
                    discount = price * 0.30;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                }

                else if (room == "president apartment")
                {
                    day -= 1;
                    price = 35 * day;
                    discount = price * 0.10;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }

            else if (day >= 10 && day <= 15)
            {
                if (room == "room for one person")
                {
                    day -= 1;
                    price = day * 18;

                    if (evaluation == "positive")
                    {
                        price = price + (price * 0.25);
                        Console.WriteLine($"{price:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        price = price - (price * 0.10);
                        Console.WriteLine($"{price:F2}");
                    }

                }

                else if (room == "apartment")
                {
                    day -= 1;
                    price = day * 25;
                    discount = price * 0.35;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                }
                else if (room == "president apartment")
                {
                    day -= 1;
                    price = day * 35;
                    discount = price * 0.15;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }

            else if (day > 15)
            {

                if (room == "room for one person")
                {
                    day -= 1;
                    price = day * 18;

                    if (evaluation == "positive")
                    {
                        price = price + (price * 0.25);
                        Console.WriteLine($"{price:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        price = price - (price * 0.10);
                        Console.WriteLine($"{price:F2}");
                    }

                }

                else if (room == "apartment")
                {
                    day -= 1;
                    price = day * 25;
                    discount = price * 0.50;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                }

                else if (room == "president apartment")
                {
                    day -= 1;
                    price = day * 35;
                    discount = price * 0.20;
                    totalPrice = price - discount;

                    if (evaluation == "positive")
                    {
                        totalPrice = totalPrice + (totalPrice * 0.25);
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                    else if (evaluation == "negative")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                }
            }
        }
    }
}
