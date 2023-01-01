using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();

            double price = 0.0;

            switch (room)
            {
                case "room for one person":
                    {
                        price = (days - 1) * 18;
                    }
                    break;
                case "apartment":
                    {
                        if (days < 10) price = (days - 1) * 25 - ((days - 1) * 25 * 0.3);
                        else if (days>=10 && days <=15) price = (days - 1) * 25 - ((days - 1) * 25 * 0.35);
                        else price = (days - 1) * 25 - ((days - 1) * 25 * 0.5);
                    }
                    break;
                case "president apartment":
                    {
                        if (days < 10) price = (days - 1) * 35 - ((days - 1) * 35 * 0.1);
                        else if(days>10 && days<15) price = (days - 1) * 35 - ((days - 1) * 35 * 0.15);
                        else price = (days - 1) * 35 - ((days - 1) * 35 * 0.2);
                    }
                    break;
            }
            if (opinion == "positive") price = price + (price * 0.25);
            else price = price - (price * 0.1);

            Console.WriteLine($"{price:f2}");
        }
    }
}
