using System;

namespace Task49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a field function that computes a trapezoid and displays it

            static void Area(int Length, int Width, int Height)
            {
                double AreaResult;
                AreaResult = 0.5 * (Length + Width) * Height;
                Console.WriteLine("\nArea of the trapezoid is: " + AreaResult);
            }
            int Numb1, Numb2, Numb3;
            Console.Write("Enter the length: ");
            Numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            Numb2 = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            Numb3 = int.Parse(Console.ReadLine());
            Area(Numb1, Numb2, Numb3);
        }
    }
}
