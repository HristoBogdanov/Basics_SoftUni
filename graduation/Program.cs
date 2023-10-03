using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 0;
            int count_grades = 0;
            double total = 0.0;
            while (count < 2 && count_grades<12)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 4.00) count++;
                total += input;
                count_grades++;
            }
            if (count_grades == 12) Console.WriteLine($"{name} graduated. Average grade: {(total/count_grades):f2}");
            else Console.WriteLine($"{name} has been excluded at {count_grades-1} grade");
        }
    }
}
