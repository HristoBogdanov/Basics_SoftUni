using System;

namespace Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 'a') result += 1;
                else if (n[i] == 'e') result += 2;
                else if (n[i] == 'i') result += 3;
                else if (n[i] == 'o') result += 4;
                else if (n[i] == 'u') result += 5;
            }
            Console.WriteLine(result);
        }
    }
}
