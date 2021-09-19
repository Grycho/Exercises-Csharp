using System;

namespace Task11a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build a triangle if there are dependencies at the same time: (𝑎<𝑏+𝑐),(𝑏<𝑎+𝑐),(𝑐<𝑎+𝑏)
            int a, b, c;
            bool numb = true;
            Console.Write("Enter the length a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the length b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the length c: ");
            c = int.Parse(Console.ReadLine());
        }
    }
}
