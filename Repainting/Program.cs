using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum_nailon = (nailon + 2) * 1.50;
            double sum_boq = (boq + boq * 0.1) * 14.5;
            double sum_razreditel = razreditel * 5;

            double sum_materiali = sum_nailon + sum_boq + sum_razreditel + 0.40;
            double sum_maistori = (sum_materiali * 0.3) * hours;

            Console.WriteLine(sum_materiali+sum_maistori);
        }
    }
}
