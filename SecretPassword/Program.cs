﻿using System;

namespace SecretPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a == "s3cr3t!P@ssw0rd") Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
