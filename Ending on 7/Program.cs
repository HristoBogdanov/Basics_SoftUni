using System;

namespace Ending_on_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i < 1000; i++)
            {
                if (i % 10 == 7) Console.WriteLine(i);
            }
        }
    }
}
