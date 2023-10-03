using System;

namespace footwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string input="";
            int total = 0;
            while(total<10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    total += int.Parse(Console.ReadLine());
                    break;
                }
                total += int.Parse(input);
            }
            if (total > 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{total-10000} steps over the goal!");
            }
            else Console.WriteLine($"{10000-total} more steps to reach goal.");
        }
    }
}
