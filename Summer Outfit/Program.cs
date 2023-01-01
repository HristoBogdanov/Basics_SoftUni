using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celtius = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (celtius >= 10 && celtius <= 18)
            {
                if (time == "Morning") Console.WriteLine($"It's {celtius} degrees, get your Sweatshirt and Sneakers.");
                else if (time == "Afternoon") Console.WriteLine($"It's {celtius} degrees, get your Shirt and Moccasins.");
                else if (time== "Evening") Console.WriteLine($"It's {celtius} degrees, get your Shirt and Moccasins.");
                else Console.WriteLine("error");
            }
            else if(celtius>18 && celtius<=24)
            {
                if (time == "Morning") Console.WriteLine($"It's {celtius} degrees, get your Shirt and Moccasins.");
                else if (time == "Afternoon") Console.WriteLine($"It's {celtius} degrees, get your T-Shirt and Sandals.");
                else if (time == "Evening") Console.WriteLine($"It's {celtius} degrees, get your Shirt and Moccasins.");
                else Console.WriteLine("error");
            }
            else if(celtius>=25)
            {
                if (time == "Morning") Console.WriteLine($"It's {celtius} degrees, get your T-Shirt and Sandals.");
                else if (time == "Afternoon") Console.WriteLine($"It's {celtius} degrees, get your Swim Suit and Barefoot.");
                else if (time == "Evening") Console.WriteLine($"It's {celtius} degrees, get your Shirt and Moccasins.");
                else Console.WriteLine("error");
            }
        }
    }
}
