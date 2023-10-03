using System;

namespace _2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nummber = 1;
            Console.WriteLine(nummber);

            while (nummber <= n)
            {
                nummber = (nummber * 2) + 1;
                if (nummber <= n) Console.WriteLine(nummber);
            }
        }
    }
}
