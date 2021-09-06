using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minytesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minytesOfArrival = int.Parse(Console.ReadLine());

            minytesOfExam += hourOfExam * 60;
            minytesOfArrival += hourOfArrival * 60;

            int difference = minytesOfExam - minytesOfArrival;

            if (difference < 0)
            {
                Console.WriteLine("Late");

                if (Math.Abs(difference) < 60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }

                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", Math.Abs(difference / 60), Math.Abs(difference % 60));
                }
            }

            else if (difference > 0)
            {
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                }

                else
                {
                    Console.WriteLine("Early");
                }

                if (difference < 60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }

                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", difference / 60, difference % 60);
                }
            }

            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}
