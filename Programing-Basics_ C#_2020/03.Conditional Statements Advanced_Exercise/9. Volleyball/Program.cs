using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double holydayInSofia = (48 - h);
            double holydayInBornCyti = 48 - holydayInSofia;

            if (year == "leap")
            {
                holydayInSofia = holydayInSofia * (3.0 / 4);
                p = p * (2.0 / 3);
                double allGame = holydayInSofia + holydayInBornCyti + p;
                allGame += allGame * 0.15;

                Console.WriteLine(Math.Floor(allGame));
            }

            else
            {
                holydayInSofia = holydayInSofia * (3.0 / 4);
                p = p * (2.0 / 3);
                double allGame = holydayInSofia + holydayInBornCyti + p;

                Console.WriteLine(Math.Floor(allGame));
            }
        }
    }
}
