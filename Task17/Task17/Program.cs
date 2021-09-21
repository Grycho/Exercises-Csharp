using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that reads two numbers, the sign of an action, and on that basis did a computation. 
             * The action sign is to be entered with one of the signs + - * / 
             * The program only performs the indicated operation. Please use the switch statement*/

            double num1, num2;
            Console.Write("Enter FIRST number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter SECOND number: ");
            num2 = double.Parse(Console.ReadLine());
            char sign;
            Console.Write("Expression symbol: ");
            sign = char.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+': Console.WriteLine("\nResult = {0}", num1 + num2); break;
                case '-': Console.WriteLine("\nResult = {0}", num1 - num2); break;
                case '*': Console.WriteLine("\nResult = {0}", num1 * num2); break;
                case '/': 
                    if (num2 == 0) 
                    { 
                        Console.WriteLine("\nWe don't divide by ZERO!"); 
                    }
                    else
                    {
                        Console.WriteLine("\nResult = {0}", num1 / num2);
                    }
                    break;
                default: Console.WriteLine("\nOption out of range!"); break;
            }
        }
    }
}
