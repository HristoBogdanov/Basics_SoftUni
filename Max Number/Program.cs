using System;
using System.Collections.Generic;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string input = Console.ReadLine();
            int number;
            while (input != "Stop")
            {
                number = int.Parse(input);
                numbers.Add(number);
                input = Console.ReadLine();
            }
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }
            Console.WriteLine(min);
        }
    }
}
