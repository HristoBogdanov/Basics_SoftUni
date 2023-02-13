using System;

namespace Creating_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number_projects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {number_projects*3} hours to complete {number_projects} project/s.");
        }
    }
}
