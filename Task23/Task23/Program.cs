﻿using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating the Greatest Common Divisor.

            int a, b;
            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
                Console.WriteLine("Greatest Common Divisor: " + a);
            }
        }
    }
}
