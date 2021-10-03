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
                Console.WriteLine("\nArea of the trapezoid is: " + AreaResult);
            }
            int Numb1, Numb2, Numb3;
            Numb1 = int.Parse(Console.ReadLine());
            Numb2 = int.Parse(Console.ReadLine());
            Numb3 = int.Parse(Console.ReadLine());
            Area(Numb1, Numb2, Numb3);
        }
    }
}
