using System;

namespace Acc_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0;
            string input = Console.ReadLine();
            double sum;


                while (input != "NoMoreMoney")
                {
                    sum = double.Parse(input);
                if (sum <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {sum:f2}");
                    total += sum;
                    input = Console.ReadLine();
                }
                }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
