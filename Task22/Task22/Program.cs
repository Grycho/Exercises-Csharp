﻿using System;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two numbers. Display from less to greater.

            int a, b, c;
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }
        }
    }
}
