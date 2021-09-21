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

            double a, b, sign;
            Console.Write("Enter FIRST number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter SECOND number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\nExpression symbol: ");
            sign = double.Parse(Console.ReadLine());
            switch (sign)
            {
                case '+': Console.WriteLine("+"); break;
                case '-': Console.WriteLine("-"); break;
                case '*': Console.WriteLine("*"); break;
                case '/': Console.WriteLine("/"); break;
                default: Console.WriteLine("Option out of range!"); break;
            }
        }
    }
}
