using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            //A menu program that will execute the following commands: total, difference, product, quotient, data entry, program exit.

            int choice;
            Console.WriteLine("MENU");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("\nSelect an action: ");
            choice = int.Parse(Console.ReadLine());

            double a, b;
            Console.Write("\nEnter the FIRST number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the SECOND number: ");
            b = double.Parse(Console.ReadLine());

            double result;
            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine("\nAddition result = " + result);
            }
            else if (choice == 2)
            {
                result = a - b;
                Console.WriteLine("\nSubtraction result = " + result);
            }
            else if (choice == 3)
            {
                result = a * b;
                Console.WriteLine("\nMultiplication result = " + result);
            }
            else if (choice == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("\nWe don't divide by ZERO!");
                }
                else
                {
                    result = a / b; 
                    Console.WriteLine("\nDivision result = " + result);
                }
            }
            else
            {
                Console.WriteLine("\nIncorrect value entered!"); 
            }
        }
    }
}
