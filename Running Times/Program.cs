using System;

namespace Running_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsttime = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());

            int total = firsttime + secondtime + thirdtime;

            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds >= 10) Console.WriteLine($"{minutes}:{seconds}");
            else Console.WriteLine($"{minutes}:0{seconds}");
        }
    }
}
