using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the area of the triangle from the length of the 3 sides

            double a, b, c;
            Console.Write("Enter the length of the side a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the side b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the side c: ");
            c = double.Parse(Console.ReadLine());

            double area, p = (a + b + c) / 2;                               //expression added to the variable
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));              //an expression that uses a square root
            Console.WriteLine("The area of the triangle is = {0}", area);
        }
    }
}
