using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            int couter = 0;
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();

            while (nextBookName != "No More Books")
            {

                if (nextBookName == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }

                couter++;
                nextBookName = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {couter} books and found it.");
            }

            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {couter} books.");
            }
        }
    }
}
