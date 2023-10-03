using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_equals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int a = int.Parse(Console.ReadLine());
                numbers.Add(a);
            }

            var sorted = numbers.OrderByDescending(x => x);
            int max = sorted.First();
            int sum = 0;
            foreach (int x in sorted) sum += x;

            if (max == (sum - max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - max}");
            }
            else if (max > (sum - max))
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {max - (sum - max)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {(sum - max)-max}");
            }
        }
    }
}
