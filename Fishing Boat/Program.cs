using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double total = 0.0;

            switch (season)
            {
                case "Spring":
                    {
                        if (count <= 6) total = 3000 - (0.1 * 3000);
                        else if (count > 6 && count <= 11) total = 3000 - (0.15 * 3000);
                        else total = 3000 - (0.25 * 3000);

                        if (count % 2 == 0) total = total - (0.05 * total);
                    }
                    break;
                case "Summer":
                case "Autumn":
                    {
                        if (count <= 6) total = 4200 - (0.1 * 4200);
                        else if (count > 6 && count <= 11) total = 4200 - (0.15 * 4200);
                        else total = 4200 - (0.25 * 4200);

                        if (count % 2 == 0 && season != "Autumn") total = total - (0.05 * total);
                    }
                    break;
                case "Winter":
                    {
                        if (count <= 6) total = 2600 - (0.1 * 2600);
                        else if (count > 6 && count <= 11) total = 2600 - (0.15 * 2600);
                        else total = 2600 - (0.25 * 2600);

                        if (count % 2 == 0) total = total - (0.05 * total);
                    }
                    break;
            }
            if (total <= budget) Console.WriteLine($"Yes! You have {(budget-total):f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {(total-budget):f2} leva.");
        }
    }
}
