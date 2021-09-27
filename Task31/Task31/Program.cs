using System;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determining the maximum in an array of random numbers

            Random Draws = new Random();
            int[] tab = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                tab[i] = Draws.Next(1, 100000);
            }
        }
    }
}
