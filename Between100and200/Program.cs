using System;

namespace Between100and200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a <= 200) Console.WriteLine("Between 100 and 200");
            else if (a < 100) Console.WriteLine("Less than 100");
            else Console.WriteLine("Greater than 200");
        }
    }
}
