using System;

namespace Book_Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_pages = int.Parse(Console.ReadLine());
            int pages_per_day = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int time = count_pages / pages_per_day;
            int result = time / days;
            Console.WriteLine(result);
        }
    }
}
