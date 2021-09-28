using System;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program will draw 3000 numbers <-1000,1000> and calculate 
             *separately the sum of even cells from even and odd cells with odd indices.*/

            Random Numb = new();
            int[] tab = new int[3000];

            for (int i = 0; i < 3000; i++)
            {
                tab[i] = Numb.Next(-1000, 1000);
            }
        }
    }
}
