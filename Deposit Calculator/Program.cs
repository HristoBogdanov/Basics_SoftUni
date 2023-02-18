using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double result_interest = sum * (interest / 100);
            double interest_month = result_interest / 12;
            double result = sum + (srok * interest_month);

            Console.WriteLine(result);
        }
    }
}
