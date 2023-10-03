using System;
using System.Collections.Generic;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int pom = i;
                while (pom > 0)
                {
                    int a = pom % 10;
                    if (a != 0) numbers.Add(a);
                    pom = pom / 10;
                }
                int count = 0;
                for (int j= 0; j < numbers.Count; j++)
                {
                    if (N % numbers[j] == 0) count++;
                }
                string pomm = i.ToString();
                if(!pomm.Contains("0"))
                { 
                if (count==numbers.Count) Console.Write($"{i} ");
                }
                numbers.Clear();
            }
        }
    }
}
