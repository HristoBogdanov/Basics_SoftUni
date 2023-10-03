using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = int.Parse(Console.ReadLine());

            while (number>sum)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            
            Console.WriteLine(sum);
        }
    }
}
