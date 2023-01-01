using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (projection)
            {
                case "Premiere":
                    Console.WriteLine($"{(12*rows*columns):f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(7.5 * rows * columns):f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(5 * rows * columns):f2} leva");
                    break;
                default: Console.WriteLine("error");
                    break;
            }
        }
    }
}
