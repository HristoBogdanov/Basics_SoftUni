using System;

namespace Concat_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondname= Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are " + firstname + " " +secondname + ", a " + age + "-years old person from " + town +".");
        }
    }
}
