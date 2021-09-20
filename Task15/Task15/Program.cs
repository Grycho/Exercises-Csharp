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
            Console.Write("Enter the SECOND number: ");
            b = double.Parse(Console.ReadLine());

            int choice;
            Console.WriteLine("MENU: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            choice = int.Parse(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine("Addition result = " + result);
            }
            else if (choice == 2)
            {
                result = a - b;
                Console.WriteLine("Subtraction result = " + result);
            }
            else if (choice == 3)
            {
                result = a * b;
                Console.WriteLine("Multiplication result = " + result);
            }
            else if (choice == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("We don't divide by ZERO!");
                }
                else
                {
                    result = a / b;
                    Console.WriteLine("Division result = " + result);
                }
            }
            else
            {
                Console.WriteLine("Incorrect value entered!");
            }
        }
    }
}
