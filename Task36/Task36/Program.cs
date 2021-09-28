using System;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program is to draw 1000 numbers <-20000,20000> to the array to calculate 
             *the span of the set (difference between the maximum and minimum).*/

            Random Numb = new();
            int[] tab = new int[1000], Min, Max;

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = Numb.Next(-20000, 20000);
            }
        }
    }
}
