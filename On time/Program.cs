using System;

namespace On_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour_exam = int.Parse(Console.ReadLine());
            int minutes_exam= int.Parse(Console.ReadLine());
            int hour_arrival= int.Parse(Console.ReadLine()); 
            int minutes_arrival= int.Parse(Console.ReadLine());

            int total_minutes_exam = (hour_exam * 60) + minutes_exam;
            int total_minutes_arrival = (hour_arrival * 60) + minutes_arrival;

            int pom = total_minutes_exam - total_minutes_arrival;

            if (pom == 0 || (pom>0 && pom <= 30))
            {
                Console.WriteLine("On time");
                if (pom != 0)
                {
                    if (pom < 60) Console.WriteLine($"{pom} minutes before the start");
                    else
                    {
                        if ((pom % 60) > 9)
                            Console.WriteLine($"{pom / 60}:{pom % 60} hours before the start");
                        else Console.WriteLine($"{pom / 60}:0{pom % 60} hours before the start");
                    }
                }
            }
            else if (pom < 0)
            {
                Console.WriteLine("Late");
                if (pom * -1 < 60) Console.WriteLine($"{pom * -1} minutes after the start");
                else
                {
                    if (((pom * -1) % 60) > 9)
                        Console.WriteLine($"{(pom * -1) / 60}:{(pom * -1) % 60} hours after the start");
                    else Console.WriteLine($"{(pom * -1) / 60}:0{(pom * -1) % 60} hours after the start");
                }
            }
            else
            {
                Console.WriteLine("Early");

                if (pom < 60) Console.WriteLine($"{pom} minutes before the start");
                else
                {
                    if ((pom % 60) > 9)
                        Console.WriteLine($"{pom / 60}:{pom % 60} hours before the start");
                    else Console.WriteLine($"{pom / 60}:0{pom % 60} hours before the start");
                }
            }
        }
    }
}
