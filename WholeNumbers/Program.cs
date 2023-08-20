using System;
using System.Collections.Generic;

namespace WholeNumbers
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

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                if (numbers[i] < min) min = numbers[i];
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
