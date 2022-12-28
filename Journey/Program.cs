using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double total = 0.0;
            string destination = "";
            string type = "";

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    type = "Camp";
                    total = 0.3 * budget;
                }
                else if (budget > 100 && budget <= 1000)
                {
                    destination = "Balkans";
                    type = "Camp";
                    total = 0.4 * budget;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    type = "Hotel";
                    total = 0.9 * budget;
                }
            }
            else
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    type = "Hotel";
                    total = 0.7 * budget;
                }
                else if (budget > 100 && budget <= 1000)
                {
                    destination = "Balkans";
                    type = "Hotel";
                    total = 0.8 * budget;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    type = "Hotel";
                    total = 0.9 * budget;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {total:f2}");
        }
    }
}
