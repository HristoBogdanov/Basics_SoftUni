using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor_n = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            double points_total = points ;
            for (int i = 0; i < count; i++)
            {
                string name_judge = Console.ReadLine();
                double points_given = double.Parse(Console.ReadLine());
                points_total += (name_judge.Length * points_given) / 2.0;

                if (points_total > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor_n} got a nominee for leading role with {points_total:f1}!");
                    break;
                }
            }
            if (points_total <= 1250.5) Console.WriteLine($"Sorry, {actor_n} you need {(1250.5-points_total):f1} more!");
        }
    }
}
