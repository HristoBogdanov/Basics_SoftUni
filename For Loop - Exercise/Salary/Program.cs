using System;
using System.Collections.Generic;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pages = new List<string>();
            int count = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
               
                string input = Console.ReadLine();
                if (salary > 0)
                {

                    if (input == "Facebook") salary = salary - 150;
                    else if (input == "Instagram") salary = salary - 100;
                    else if (input == "Reddit") salary = salary - 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0) Console.WriteLine($"{salary:f0}");
            
        }
    }
}
