﻿using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that reads two numbers, the sign of an action, and on that basis did a computation. 
             * The action sign is to be entered with one of the signs + - * / 
             * The program only performs the indicated operation. Please use the switch statement*/

            float num1, num2, result=0;
            Console.Write("Enter FIRST number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter SECOND number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("\nExpression symbol: ");
            string sign = (Console.ReadLine());

            switch (sign)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": 
                    if (num2 == 0) 
                    { 
                        Console.WriteLine("We don't divide by ZERO!"); 
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default: Console.WriteLine("Option out of range!"); break;
            }
            Console.WriteLine("Result = " + result);
        }
    }
}
