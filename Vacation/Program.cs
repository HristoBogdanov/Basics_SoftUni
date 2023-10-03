using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int count = 0;
            int spend_count = 0;
            string action;
            double sum;
            while (spend_count < 5 && money<price)
            {
                action = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                count++;

                if (action == "spend")
                {
                    if (sum > money)money= 0;
                    else money -= sum;

                    spend_count++;
                   
                }
                else
                {
                    money += sum;
                    spend_count = 0;
                }
            }
            if (spend_count == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{count}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
        }
    }
}
