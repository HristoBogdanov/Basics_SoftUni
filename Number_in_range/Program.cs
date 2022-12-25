using System;

namespace Number_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number != 0)
            {
                if (number >= -100 && number <= 100) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
            else Console.WriteLine("No");
        }
    }
}
