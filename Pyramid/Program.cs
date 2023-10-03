using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            bool flag = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (count > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write($"{count} ");
                    count++;
                }
                if (flag)
                    break;
                Console.WriteLine();
            }
        }
    }
}
