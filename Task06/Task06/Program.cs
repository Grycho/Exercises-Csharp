using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using variables of type double calculate the expression: a2 + b for c>0; a - b2 for c<0; 1/a-b for c=0

            int a, b, c;
            Console.Write("Enter a value for a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for c: ");
            c = int.Parse(Console.ReadLine());

            if (c > 0)
            {
                int result = ((a * a) + b);
                Console.WriteLine("\nThe value of the expression is: {0}", result);
            }
            else if (c < 0)
            {
                int result = ((a - b) * b);
                Console.WriteLine("\nThe value of the expression is: {0}", result);
            }
            else if ((a - b) == 0)
            {
                Console.WriteLine("\nWe don't divide by ZERO!");
            }
            else
            {
                double result = (double)1 / (a - b);                                // on else must be changed for double variable because here is denominator
                Console.WriteLine("\nThe value of the expression is: {0}", result);
            }
        }
    }
}
