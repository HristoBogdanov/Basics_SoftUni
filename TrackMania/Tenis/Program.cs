using System;

namespace Tenis
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            double points_generated=0;
            double won_count = 0;

            for (int i = 0; i < count; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    start += 2000;
                    points_generated += 2000;
                    won_count++;
                }
                else if(result=="F")
                {
                    start += 1200;
                    points_generated += 1200;
                }
                else if (result == "SF")
                {
                    start += 720;
                    points_generated += 720;
                }
            }
            Console.WriteLine($"Final points: {start}");
            Console.WriteLine($"Average points: {Math.Floor(points_generated/count)}");
            Console.WriteLine($"{((won_count/count)*100):f2}%");
        }
    }
}
