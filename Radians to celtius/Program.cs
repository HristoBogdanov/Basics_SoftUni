using System;

namespace Radians_to_celtius
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());

            double celtius = radian * 180 / Math.PI;

            Console.WriteLine(celtius);
        }
    }
}
