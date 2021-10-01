using System;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Draw a 15x15 matrix, display, give the maximum value and 
             *coordinates of the cell with the maximum value.*/

            Random Numb = new();
            int[,] tab = new int[15, 15];

            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    tab[x, y] = Numb.Next(-100, 100);
                    Console.Write("{0} \t", tab[x, y]);
                }
                Console.WriteLine();
            }
            int MaxX = 0, MaxY = 0, MaxValue = tab[0, 0];
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    if (MaxValue< tab[x, y])
                    {
                        MaxValue = tab[x, y];
                        MaxX = x;
                        MaxY = y;
                    }
                }
            }
            Console.WriteLine("\nMaximum value {0} in a cell with coordinates [{1},{2}]", MaxValue, MaxX, MaxY);
        }
    }
}
