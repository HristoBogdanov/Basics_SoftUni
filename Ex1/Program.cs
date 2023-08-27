using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceProcesor = double.Parse(Console.ReadLine());
            double priceCard = double.Parse(Console.ReadLine());
            double priceRam = double.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());
            double discount= double.Parse(Console.ReadLine());

            double total_Ram = (priceRam * 1.57) * countRam;
            double total_Procesor = priceProcesor * 1.57;
            total_Procesor = total_Procesor - (discount * total_Procesor);
            double total_Card = priceCard * 1.57;
            total_Card=total_Card-(discount*total_Card);

            double result = total_Card + total_Procesor + total_Ram;

            Console.WriteLine($"Money needed - {result:f2} leva.");
        }
    }
}
