using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double dailyIncome = double.Parse(Console.ReadLine());
            double taxes = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double total = (budget * 5) + (dailyIncome * 5) - taxes;
            if (total >= priceGift) Console.WriteLine($"Profit: {total:f2} BGN, the gift has been purchased.");
            else Console.WriteLine($"Insufficient money: {(priceGift-total):f2} BGN.");
        }
    }
}
