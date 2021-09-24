using System;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program counts the sum of 1000 random values.

            Random draws = new Random();
            int[] tab = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = draws.Next(10, 50);
            }
            int sum = 0;
            foreach (var element in tab)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
