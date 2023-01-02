using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double price_costumes = 0;
            double decour_price = budget * 0.1;
            if (number > 150) price_costumes = (number * price) - (number * price) * 0.1;
            else price_costumes = (number * price);

            if (decour_price + price_costumes > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((decour_price + price_costumes) - budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-(price_costumes+decour_price)):f2} leva left.");
            }
        }
    }
}
