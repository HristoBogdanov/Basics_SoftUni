﻿using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(2.5 * quantity):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(1.2 * quantity):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(0.85 * quantity):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(1.45 * quantity):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(2.7 * quantity):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(5.5 * quantity):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(3.85 * quantity):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(2.7 * quantity):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(1.25 * quantity):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(0.9 * quantity):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(1.6 * quantity):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(3 * quantity):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(5.6 * quantity):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(4.2 * quantity):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else Console.WriteLine("error");
                    
        }
    }
}
