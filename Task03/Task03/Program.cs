using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the area of the triangle from the length of the 3 sides

            double a, b, c;
            Console.WriteLine("Enter the length of the side a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the side b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the side c: ");
            c = double.Parse(Console.ReadLine());

            double area, p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
