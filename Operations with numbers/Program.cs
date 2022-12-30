using System;

namespace Operations_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string evenorodd = "";

            switch (operation)
            {
                case '+':
                    {
                        if ((n1 + n2) % 2 == 0) evenorodd = "even";
                        else evenorodd = "odd";

                        Console.WriteLine($"{n1} + {n2} = {n1+n2} - {evenorodd}");
                    }
                    break;
                case '-':
                    {
                        if ((n1 - n2) % 2 == 0) evenorodd = "even";
                        else evenorodd = "odd";

                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - {evenorodd}");
                    }
                    break;
                case '*':
                    {
                        if ((n1 * n2) % 2 == 0) evenorodd = "even";
                        else evenorodd = "odd";

                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - {evenorodd}");
                    }
                    break;
                case '/':
                    {
                        if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                        else
                        {
                            double result;
                            double n22 = n2;
                            result = n1 / n22;
                            Console.WriteLine($"{n1} / {n2} = {result:f2}");
                        }
                    }
                    break;
                case '%':
                    {
                        if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                        else
                        {
                            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                        }
                    }
                    break;
            }
        }
    }
}
