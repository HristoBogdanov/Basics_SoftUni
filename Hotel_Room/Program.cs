using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double total_apartment = 0.0;
            double total_studio = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    {
                        if (count <= 7)
                        {
                            total_apartment = 65 * count;
                            total_studio = 50 * count;
                        }
                        else if (count > 7 && count <= 14)
                        {
                            total_studio = (50 * count) - (0.05 * count * 50);
                            total_apartment = count * 65;
                        }
                        else if (count > 14)
                        {
                            total_apartment = (65 * count)-(0.1*count*65);
                            total_studio = (count * 50) - (count * 50 * 0.3);
                        }
                    }
                    break;
                case "June":
                case "September":
                    {
                        if (count > 14)
                        {
                            total_apartment = (68.70 * count) - (68.70 * count * 0.1);
                            total_studio = (count * 75.2) - (0.2 * 75.2 * count);
                        }
                        else
                        {
                            total_studio = count * 75.2;
                            total_apartment = 68.70 * count;
                        }
                    }
                    break;
                case "July":
                case "August":
                    {
                        if (count > 14)
                        {
                            total_apartment = (77 * count) - (77 * count * 0.1);
                            total_studio = 76 * count;
                        }
                        else
                        {
                            total_apartment = 77 * count;
                            total_studio = 76 * count;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {total_apartment:f2} lv.");
            Console.WriteLine($"Studio: {total_studio:f2} lv.");
        }
    }
}
