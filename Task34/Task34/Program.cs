using System;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program: Array of 1000 numbers <-100,1000>. Every value <100 has 10,000 added.

            Random Numb = new();
            int[] tab = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = Numb.Next(-100, 1000);
            }
            for (int i = 0; i < 1000; i++)
            {
                if (tab[i] < 100)
                {
                    tab[i] = tab[i] + 10000;
                }
            }
            foreach (var Added in tab)
            {
                Console.WriteLine(Added);
            }
        }
    }
}
