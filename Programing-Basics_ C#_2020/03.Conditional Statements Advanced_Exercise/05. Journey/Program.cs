using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destinacion = "";
            string typeJourney = "";
            double leaveMoney = 0;

            if (budget <= 100)
            {
                destinacion = "Bulgaria";

                if (season == "summer")
                {
                    leaveMoney = budget * 0.30;
                    typeJourney = "Camp";
                }

                else if (season == "winter")
                {
                    leaveMoney = budget * 0.70;
                    typeJourney = "Hotel";
                }
            }

            else if (budget <= 1000)
            {
                destinacion = "Balkans";

                if (season == "summer")
                {
                    leaveMoney = budget * 0.40;
                    typeJourney = "Camp";
                }

                else if (season == "winter")
                {
                    leaveMoney = budget * 0.80;
                    typeJourney = "Hotel";
                }
            }

            else if (budget > 1000)
            {
                destinacion = "Europe";
                leaveMoney = budget * 0.90;
                typeJourney = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destinacion}");
            Console.WriteLine($"{typeJourney} - {leaveMoney:F2}");
        }
    }
}
