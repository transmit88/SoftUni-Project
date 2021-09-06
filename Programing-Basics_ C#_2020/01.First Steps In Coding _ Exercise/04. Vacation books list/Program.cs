using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int countDay = int.Parse(Console.ReadLine());

            double hours = countPages / pages;
            double hoursCount = hours / countDay;

            Console.WriteLine(hoursCount);
        }
    }
}
