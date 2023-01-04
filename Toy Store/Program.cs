using System;

namespace Toy_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzles * 2.60 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;

            if (puzzles+dolls+bears+minions+trucks>=50) total = total - total * 0.25;
            total = total - total * 0.1;

            if (total >= price) Console.WriteLine($"Yes! {total-price:f2} lv left.");
            else Console.WriteLine($"Not enough money! {price-total:f2} lv needed.");
        }
    }
}
