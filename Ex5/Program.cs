using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int total = 0;
            while (input != "closed" && total<goal)
            {
                if (total >= goal) break;
                string job = input;
                string specifics = Console.ReadLine();
                if (job == "haircut")
                {
                    if (specifics == "mens") total += 15;
                    else if (specifics == "ladies") total += 20;
                    else total += 10;
                }
                else
                {
                    if (specifics == "touch up") total += 20;
                    else total += 30;
                }
                if (total >= goal) break;
                input = Console.ReadLine();
            }
            if (total >= goal)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {total}lv.");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {(goal-total)}lv. more.");
                Console.WriteLine($"Earned money: {total}lv.");
            }
            
        }
    }
}
