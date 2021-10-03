﻿using System;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a NumberDigits function that returns the number of digits in an integer

            static int NumberDigits(int x)
            {
                int Value = 0;
                while (x!= 0)
                {
                    Value++;
                    x /= 10;
                }
                return Value;
            }
            int Numb;
            Console.Write("Enter a number: ");
            Numb = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResult: {0}", NumberDigits(Numb));
        }
    }
}
