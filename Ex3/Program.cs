using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double total = 0.0;
            if (place == "Bulgaria")
            {
                total = points * countDancers;
                if (season == "summer")
                {
                    total = total - 0.05 * total;
                }
                else
                {
                    total = total - (0.08 * total);
                }
            }
            else
            {
                total = points * countDancers;
                total = total + (0.5 * total);
                if (season == "summer")
                {
                    total = total - 0.1 * total;
                }
                else
                {
                    total = total - (0.15 * total);
                }
            }
            double charity = 0.75 * total;
            total = total - (0.75 * total);
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {(total/countDancers):f2}");
        }
    }
}
