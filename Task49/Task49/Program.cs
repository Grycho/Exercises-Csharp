using System;

namespace Task49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a field function that computes a trapezoid and displays it

            void Area(int Length, int Width, int Height)
            {
                double AreaResult;
                AreaResult = 0.5 * (Length + Width) * Height;
                Console.WriteLine("\nArea of the trapezoid is: ");
            }
        }
    }
}
