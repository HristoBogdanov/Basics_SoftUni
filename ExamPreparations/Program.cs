using System;
using System.Collections.Generic;

namespace ExamPreparations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> problems = new List<string>();
            int count = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int count_grades = 0;
            int count_bad_grades = 0;
            double average = 0.0;
            while (name != "Enough" && count_bad_grades < count)
            {
               
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4) count_bad_grades++;
                if(count_bad_grades<count) {
                    name = Console.ReadLine();
                    average += grade;
                    count_grades++;
                    problems.Add(name);
                }
                
            }
            if (name == "Enough")
            {
                Console.WriteLine($"Average score: {(average / count_grades):f2}");
                Console.WriteLine($"Number of problems: {count_grades}");
                Console.WriteLine($"Last problem: {problems[count_grades - 2]}");
            }
            else
            {
                Console.WriteLine($"You need a break, {count_bad_grades} poor grades.");
            }
        }
    }
}
