using System;

namespace Basketball_equpment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax - tax * 0.4;
            double shirt = shoes - shoes * 0.2;
            double ball = shirt * 0.25;
            double accessories = ball * 0.2;

            double result = tax + shoes + shirt + ball + accessories;
            Console.WriteLine(result);
        }
    }
}
