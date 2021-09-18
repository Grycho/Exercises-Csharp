using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // a program that calculates the area of a cuboid

            int a, b, h;
            Console.Write("Enter the length: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            h = int.Parse(Console.ReadLine());

            int area;
            area = 2 * (a * b + b * h + a * h);
            Console.WriteLine("The area of cuboid totals = {0}", area);
        }
    }
}
