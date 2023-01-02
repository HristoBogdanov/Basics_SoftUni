using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episode = double.Parse(Console.ReadLine());
            double break_time = double.Parse(Console.ReadLine());

            double time_lunch = break_time / 8;
            double time_rest = break_time / 4;
            double break_total = break_time - (time_rest + time_lunch);


            if (break_total >= episode) Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(break_total-episode)} minutes free time.");
            else Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episode-break_total)} more minutes.");
        }
    }
}
