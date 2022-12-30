using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double total = 0.0;

            if (type == "Roses")
            {
                if (count > 80) total = (count * 5) - 0.1 * (count * 5);
                else total = count * 5;
            }
            else if (type == "Dahlias")
            {
                if (count > 90) total = (count * 3.8) - 0.15 * (count * 3.8);
                else total = count * 3.8;
            }
            else if (type == "Tulips")
            {
                if (count > 80) total = (count * 2.8) - 0.15 * (count * 2.8);
                else total = count * 2.8;
            }
            else if (type == "Narcissus")
            {
                if (count < 120) total = (count * 3) + 0.15 * (count * 3);
                else total = count*3;
            }
            else if (type == "Gladiolus")
            {
                if (count < 80) total = (count * 2.5) + 0.2 * (count * 2.5);
                else total = count * 2.5;
            }
            if (total <= budget) Console.WriteLine($"Hey, you have a great garden with {count} {type} and {(budget-total):f2} leva left.");
            else Console.WriteLine($"Not enough money, you need {(total-budget):f2} leva more.");
        }
    }
}
