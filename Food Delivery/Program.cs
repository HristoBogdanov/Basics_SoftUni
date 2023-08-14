using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish= int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double result_meal = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            double desert = result_meal * 0.2;

            double result = result_meal + desert + 2.5;
            Console.WriteLine(result);

        }
    }
}
