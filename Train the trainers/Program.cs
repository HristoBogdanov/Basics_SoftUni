using System;

namespace Train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string namePresentation = Console.ReadLine();
            double total = 0.0;
            double finalGrade = 0.0;
            int count = 0;
            while(namePresentation!="Finish")
            { 
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                total += grade;
            }
                total = total / n;
                count++;
                finalGrade += total;
                Console.WriteLine($"{namePresentation} - {total:f2}.");
                namePresentation = Console.ReadLine();
                total = 0.0;
            }
            Console.WriteLine($"Student's final assessment is {(finalGrade/count):f2}.");
        }
    }
}
