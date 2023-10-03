using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int count = a * b*c;

            string input = "";
            while (count > 0)
            {
                input = Console.ReadLine();
                if (input == "Done") break;
                else count -= int.Parse(input);
            }
            if (count <= 0) Console.WriteLine($"No more free space! You need {count*(-1)} Cubic meters more.");
            else Console.WriteLine($"{count} Cubic meters left.");
            
        }
    }
}
