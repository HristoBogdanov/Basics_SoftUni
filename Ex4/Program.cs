using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int coundDays = int.Parse(Console.ReadLine());
            double totalLiters=0.0;
            double totalDegrees=0.0;
            for (int i = 0; i < coundDays; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                totalDegrees += degrees * quantity;
                totalLiters += quantity;
            }
            totalDegrees = totalDegrees / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {totalDegrees:f2}");
            if (totalDegrees < 38) Console.WriteLine("Not good, you should baking!");
            else if (totalDegrees >= 38 && totalDegrees <= 42) Console.WriteLine("Super!");
            else Console.WriteLine($"Dilution with distilled water!");
        }
    }
}
