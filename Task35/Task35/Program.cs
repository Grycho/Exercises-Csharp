using System;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program draws 30 numbers <0,100>. First it displays even cells, later odd numbers

            Random Numb = new();
            int[] tab = new int[30];

            for (int i = 0; i < 30; i++)
            {
                tab[i] = Numb.Next(0, 100);
            }
            for (int i = 0; i < 30; i+=2)
            {
                Console.WriteLine(tab[i]);
            }
            for (int i = 1; i < 30; i+=2)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
