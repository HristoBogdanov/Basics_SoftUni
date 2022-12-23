using System;

namespace Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number != 0)
            {
                if (number < 100 || number > 200) Console.WriteLine("invalid");
            }
        }
    }
}
