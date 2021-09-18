using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            // evaluating the value of an expression

            double a, b;
            Console.WriteLine("Enter a value A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value B: ");
            b = double.Parse(Console.ReadLine());

            if ((a + b)*(a + b) != 0)
            {
                double expression;
                expression = (a * a + b) / Math.Pow(a + b, 2);  // adding a power to an expression (a2 + b) / (a + b)2
            }
            else
            {
                Console.WriteLine("We don't divide by ZERO");   // if the denominator is zero show this announcement
            }
        }
    }
}
