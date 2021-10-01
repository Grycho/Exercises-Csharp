using System;

namespace Task42
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw a 10x10 matrix and display an array, then display the sum of each column

            Random Numb = new();
            int[,] tab = new int[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    tab[x, y] = Numb.Next(-100, 100);
                    Console.WriteLine("{0} \t", tab[x, y]);
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 10; y++)
            {
                int Sum = 0;
                for (int x = 0; x < 10; x++)
                {
                    Sum += tab[x, y];
                }
                Console.WriteLine("{0} \t", Sum);
            }
        }
    }
}
