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
                    Console.WriteLine("{0} \t", tab[x, y]);
                }
                Console.WriteLine();
            }
            int MaxX = 0, MaxY = 0, MaxValue = tab[0, 0];
            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 15; x++)
                {

                }
            }
        }
    }
}
