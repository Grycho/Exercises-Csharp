using System;

namespace Task48
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that takes a positive natural number N (n < 30) from the user 
             * and creates an array 'a' of boolean variables of size n × n.
             * 
             * Then the program should fill the created array, so that a [i] [j] = true, 
             * if the numbers (i + 1) and (j + 1) are relatively prime, i.e. they do not 
             * have common divisors beyond 1. The array created in this way should be printed 
             * on the screen, the "+" sign should be displayed for the true value, 
             * and the sign for the false value is "." */

            static bool RelativelyFirst(int NumberCells, int x)
            {
                while (NumberCells != x)
                {
                    if (NumberCells > x) NumberCells -= x;
                    else x -= NumberCells;
                }
                if (NumberCells == 1) return true;
                else return false;
            }

            Console.Write("Enter the number (> 0): ");
            int Numb = int.Parse(Console.ReadLine());
            bool[,] arr = new bool[Numb, Numb];

            for (int i = 0; i < Numb; i++)
            {
                for (int j = 0; j < Numb; j++)
                {
                    arr[i, j] = RelativelyFirst(i + 1, j + 1);
                }
            }
            for (int i = 0; i < Numb; i++)
            {
                for (int j = 0; j < Numb; j++)
                {
                    if (arr[i, j]) Console.Write("+ ");
                    else Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}
