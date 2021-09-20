using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            //A menu program that will execute the following commands: total, difference, product, quotient, data entry, program exit.

            double a, b;
            Console.Write("Enter the FIRST number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the FIRST number: ");
            b = double.Parse(Console.ReadLine());
            int menu;
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: Console.WriteLine("1. Addition"); break;
                case 2: Console.WriteLine("2. Subtraction"); break;
                case 3: Console.WriteLine("3. Multiplication"); break;
                case 4: Console.WriteLine("4. Division"); break;
                default: Console.WriteLine("Incorrect value entered!"); break;
            }
        }
    }
}
