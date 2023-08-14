using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double result = (pens * 5.8) + (markers * 7.2) + (liters * 1.2);
            double discount_sum = result * discount / 100;
            double result_discount = result - discount_sum;
            Console.WriteLine(result_discount);
        }
    }
}
