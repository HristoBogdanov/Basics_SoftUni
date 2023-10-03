using System;

namespace SumOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string n = i.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < n.Length; j++)
                {
                    if ((j + 1) % 2 == 0)
                    {
                        evenSum += int.Parse("" + n[j]);
                    }
                    else
                    {
                        oddSum += int.Parse("" + n[j]);
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(n + " ");
                }
            }
        }
    }
}
