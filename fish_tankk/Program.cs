using System;

namespace fish_tankk
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent= double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volume_liters = volume * 0.001;
            double result = volume_liters * (1 - (percent / 100));
            Console.WriteLine(result);
        }
    }
}
