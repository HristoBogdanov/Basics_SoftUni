using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int q = 0; q <= n; q++)
                    {
                        if (i + j + q == n) count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
