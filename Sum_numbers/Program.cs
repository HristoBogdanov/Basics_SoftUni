using System;
using System.Collections.Generic;

namespace Sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int a = int.Parse(Console.ReadLine());
                numbers.Add(a);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
