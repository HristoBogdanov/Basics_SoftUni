using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * a):f3}");
            }
            else if (name == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"{(a * b):f3}");
            }
            else if (name == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(Math.PI * a * a):f3}");
            }
            else if (name == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                Console.WriteLine($"{((a*h)/2):f3}");
            }
        }
    }
}
