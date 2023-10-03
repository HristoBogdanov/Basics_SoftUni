using System;

namespace Magic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic_number = int.Parse(Console.ReadLine());
            int count = 0;
            int matches = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == magic_number)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic_number})");
                        matches++;
                        return;
                    }

                }
            }
            if (matches == 0) Console.WriteLine($"{count} combinations - neither equals {magic_number}");
        }
    }
}
