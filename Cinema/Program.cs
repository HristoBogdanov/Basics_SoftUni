using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double studentsCount = 0;
            double standartCount = 0;
            double kidCount = 0;
            double countTickets = 0;
            double totalCount = 0;
            while (input != "Finish")
            {
                countTickets = 0;
                string movie = input;
                int capacity = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                while (type != "End" && type!="Finish" && countTickets<capacity)
                {
                    if (type == "student") studentsCount++;
                    else if (type == "standard") standartCount++;
                    else if ((type == "kid")) kidCount++;

                    countTickets++;
                    if (countTickets == capacity) break;
                    type = Console.ReadLine();
                }
                totalCount += countTickets;
                Console.WriteLine($"{movie} - {((countTickets/capacity)*100):f2}% full.");
                if (type == "Finish") break;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalCount}");
            Console.WriteLine($"{((studentsCount/totalCount)*100):f2}% student tickets.");
            Console.WriteLine($"{((standartCount / totalCount) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((kidCount / totalCount) * 100):f2}% kids tickets.");
        }
    }
}
