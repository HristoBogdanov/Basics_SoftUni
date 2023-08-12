using System;
using System.Collections.Generic;

namespace Left_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i <count*2; i++)
            {
                int a = int.Parse(Console.ReadLine());
                numbers.Add(a);
            }
            int sum_left = 0;
            int sum_right = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                sum_left += numbers[i];
            }
            for(int i=numbers.Count-1;i>=numbers.Count/2;i--)
            {
                sum_right += numbers[i];
            }

            if (sum_right == sum_left) Console.WriteLine($"Yes, sum = {sum_left}");
            else if (sum_left > sum_right) Console.WriteLine($"No, diff = {sum_left-sum_right}");
            else Console.WriteLine($"No, diff = {sum_right - sum_left}");
        }
    }
}
