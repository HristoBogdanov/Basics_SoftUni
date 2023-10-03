using System;

namespace Sum_prime_Non_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prime = 0;
            int NonPrime = 0;
            string input = Console.ReadLine();
            while (input != "stop")
            {
                int a = int.Parse(input);
                int count = 0;
                if (a < 0) {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                }
                else
                { 
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0) count++;
                }
                if (count > 0) NonPrime += a;
                else Prime += a;

                count = 0;
                input = Console.ReadLine();
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {Prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {NonPrime}");
        }
    }
}
