﻿using System;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program draws 1000 numbers from the range (1,10000) and displays the numbers above the average.

            Random Numb = new Random();
            int[] tab = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = Numb.Next(1, 10000);
            }
            int Sum = 0;
            foreach (var Element in tab)
            {
                Sum += Element;
            }

        }
    }
}
