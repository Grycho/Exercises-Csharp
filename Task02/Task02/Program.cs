using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the hypotenuse in a right triangle

            int a, b;
            Console.Write("Enter the length: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            b = int.Parse(Console.ReadLine());

            double c;
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("The hypotenuse in a right triangle is = {0}", c);
        }
    }
}
