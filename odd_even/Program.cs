using System;
using System.Collections.Generic;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>arr = new List<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr.Add(a);
            }
            int sum_odds = 0;
            int sum_evens = 0;
            for(int i=0;i<arr.Count;i=i+2)
            {
                sum_evens += arr[i];
            }

            for (int i = 1; i < arr.Count; i = i + 2)
            {
                sum_odds += arr[i];
            }
            if (sum_evens == sum_odds)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum_odds}");
            }
            else if (sum_evens > sum_odds)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum_evens - sum_odds}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum_odds - sum_evens}");
            }
        }
    }
}
