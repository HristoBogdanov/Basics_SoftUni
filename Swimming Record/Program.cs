using System;

namespace Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double total_time = distance * time;
            double time_delay = Math.Floor(distance / 15) * 12.5;
            double result_time = total_time + time_delay;

            if (result_time < record) Console.WriteLine($" Yes, he succeeded! The new world record is {result_time:f2} seconds.");
            else Console.WriteLine($"No, he failed! He was {(result_time-record):f2} seconds slower.");
        }
    }
}
