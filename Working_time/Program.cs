﻿using System;

namespace Working_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day != "Sunday")
            {
                if (hour >= 10 && hour <= 18) Console.WriteLine("open");
                else Console.WriteLine("closed");
            }
            else Console.WriteLine("closed");
        }
    }
}
