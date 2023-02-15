using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());

            double discount = 0.18 * (yards * 7.61);
            double result = (yards * 7.61) - discount;

            Console.WriteLine($"The final price is: {result} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
