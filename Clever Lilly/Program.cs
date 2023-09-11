using System;

namespace Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price_washer = double.Parse(Console.ReadLine());
            int price_toy = int.Parse(Console.ReadLine());

            double total = 0.0;
            int count_toys = 0;
            int j = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    total += (j * 10) - 1;
                    j++;
                }
                else count_toys++;
            }

            total += (count_toys * price_toy);

            if (total >= price_washer) Console.WriteLine($"Yes! {(total-price_washer):f2}");
            else Console.WriteLine($"No! {(price_washer-total):f2}");
        }
    }
}
