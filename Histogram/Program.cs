using System;
using System.Collections.Generic;
using System.Linq;

namespace Histogram
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

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] < 200) p1++;
                else if (numbers[i] >= 200 && numbers[i] < 400) p2++;
                else if (numbers[i] >= 400 && numbers[i] < 600) p3++;
                else if (numbers[i] >= 600 && numbers[i] < 800) p4++;
                else if (numbers[i] >=800) p5++;
            }
            Console.WriteLine($"{(p1/count)*100:f2}%");
            Console.WriteLine($"{(p2 / count) * 100:f2}%");
            Console.WriteLine($"{(p3 / count) * 100:f2}%");
            Console.WriteLine($"{(p4 / count) * 100:f2}%");
            Console.WriteLine($"{(p5 / count) * 100:f2}%");
        }
    }
}
