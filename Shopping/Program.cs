using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int procesors= int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double total_videocards = videocards * 250;
            double total_procesors = (total_videocards * 0.35) * procesors;
            double total_ram = (total_videocards * 0.1) * ram;

            double total = total_procesors + total_ram + total_videocards;

            if (videocards > procesors) total = total - (total * 0.15);

            if (total <= budget) Console.WriteLine($"You have {budget-total:f2} leva left!");
            else Console.WriteLine($"Not enough money! You need {total-budget:f2} leva more!");
        }
    }
}
