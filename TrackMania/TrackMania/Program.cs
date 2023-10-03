using System;
using System.Collections.Generic;

namespace TrackMania
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> groups = new List<int>();
            int count = int.Parse(Console.ReadLine());
            double Musala = 0;
            double Monblon = 0;
            double Kalimandjaro = 0;
            double K2 = 0;
            double Everest = 0;
            double total =0;
            for (int i = 0; i < count; i++)
            {
                int group = int.Parse(Console.ReadLine());
                groups.Add(group);
            }
            foreach (int x in groups)
            {
                if (x <= 5) Musala += x;
                else if (x > 5 && x <= 12) Monblon += x;
                else if (x > 12 && x <= 25) Kalimandjaro += x;
                else if (x > 25 && x <= 40) K2 += x;
                else Everest += x;

                total += x;
            }

            Console.WriteLine($"{((Musala/total)*100):f2}%");
            Console.WriteLine($"{((Monblon / total) * 100):f2}%");
            Console.WriteLine($"{((Kalimandjaro / total) * 100):f2}%");
            Console.WriteLine($"{((K2 / total) * 100):f2}%");
            Console.WriteLine($"{((Everest / total) * 100):f2}%");
        }
    }
}
