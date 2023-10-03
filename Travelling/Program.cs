using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input !="End")
            {
                string destination = input;
                int sum = int.Parse(Console.ReadLine());
                int total = 0;
                while (total < sum)
                {
                    string pom = Console.ReadLine();
                    if (pom == "End") return;
                    else
                    {
                        int a = int.Parse(pom);
                        total +=a;
                    }
                }
                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
                if (input == "End") return;
            }
            
        }
    }
}
