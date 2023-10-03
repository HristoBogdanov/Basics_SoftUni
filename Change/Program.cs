using System;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = double.Parse(Console.ReadLine()) * 100;
            int count = 0;

            while (total > 0)
            {
                if (total >= 200)
                {
                    total -= 200;
                }
                else if (total >= 100)
                {
                    total -= 100;
                }
                else if (total >= 50)
                {
                    total -= 50;
                }
                else if (total >= 20)
                {
                    total -= 20;
                }
                else if (total >= 10)
                {
                    total -= 10;
                }
                else if (total >= 5)
                {
                    total -= 5;
                }
                else if (total >= 2)
                {
                    total -= 2;
                }
                else if (total >= 1)
                {
                    total -= 1;
                }
                else break;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
