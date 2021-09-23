using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating the Greatest Common Divisor.

            int a, b;
            Console.Write("Input first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
                Console.WriteLine("GCD is: " + a);
            }
        }
    }
}
