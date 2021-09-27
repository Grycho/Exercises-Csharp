using System;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program that determines how many times the maximum.

            Random Numb = new();
            int[] tab = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = Numb.Next(-100, 30000);
            }
            int Max = tab[0];
            foreach (var Element in tab)
            {

            }
        }
    }
}
