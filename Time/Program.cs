using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newHours = 0;
            int newMinutes=0;

            if (minutes < 45) { newMinutes = minutes + 15; newHours = hours; }
            else if (minutes == 45) { newMinutes = 00; newHours = hours + 1; }
            else if (minutes > 45) { newMinutes = (minutes + 15) - 60; newHours = hours + 1; }
            if (minutes > 45 && hours == 23) { newHours = 0;newMinutes = (minutes + 15) - 60; }
            if (minutes == 45 && hours == 23) { newHours = 0;newMinutes = 00; }

            if(newMinutes>=10) Console.WriteLine($"{newHours}:{newMinutes}");
            else Console.WriteLine($"{newHours}:0{newMinutes}");
        }
    }
}
