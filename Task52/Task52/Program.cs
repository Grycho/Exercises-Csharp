﻿using System;

namespace Task52
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Function that draws a horizontal histogram from asterisks, illustrating 
             *the distribution of values in a user-supplied string of numbers between 1-5.*/

            static void Chart(params int [] Tab)
            {
                int[] Count = new int[6];
                foreach (var Element in Tab)
                {
                    Count[Element - 1]++;
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(i+1+"");
                    for (int j = 0; j < Count[i]; j++)
                    {

                    }
                }
            }
        }
    }
}
