﻿using System;

namespace Task45
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program includes a function that loads two coordinates of the segment 
             *x1, y1, x2, y2 and returns the length of the segment (non-integer)*/

            double LengthSection(int x1, int y1, int x2, int y2)
            {
                double Value;
                Value = Math.Abs(x2 - x2) * Math.Abs(x2 - x1) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2);
                Value = Math.Sqrt(Value);
                return Value;
            }
            int Numb1, Numb2, Numb3, Numb4;
            Console.WriteLine("First coordinate: ");
            Numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First coordinate: ");
            Numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("First coordinate: ");
            Numb3 = int.Parse(Console.ReadLine());
            Console.WriteLine("First coordinate: ");
            Numb4 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResult: {0}", LengthSection(Numb1, Numb2, Numb3, Numb4));
        }
    }
}
