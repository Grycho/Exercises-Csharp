﻿using System;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program error catching

            bool Error = false;
            double Sum;
            bool Quant1, Quant2;
            Console.Write("Enter first number: ");
            Quant1 = int.TryParse(Console.ReadLine(), out int Numb1);
            Console.Write("Enter second number: ");
            Quant2 = int.TryParse(Console.ReadLine(), out int Numb2);

            if (Quant1 == true && Quant2 == true)
            {
                try
                {
                    Sum = Numb1 / Numb2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("A runtime error has occurred");
                    Error = true;
                }
                if (!Error) Console.WriteLine("Result: {0}", (double)Numb1/Numb2);
            }
        }
    }
}
