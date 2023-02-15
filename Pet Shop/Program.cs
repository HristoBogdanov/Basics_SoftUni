using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers_dogs = int.Parse(Console.ReadLine());
            int numbers_cats = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(numbers_cats*4) + (numbers_dogs*2.5)} lv.");
        }
    }
}
