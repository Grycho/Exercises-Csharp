using System;

namespace Task53
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that draws a Christmas tree from stars with a value specified by the user. 
             *Example for value 4 (height 4 is for the lower element, higher is 1 less)*/

            static void Tree (int Numb)
            {
                for (int i = 0; i < Numb - 1; i++)
                {
                    for (int j = 0; j < Numb - 1 - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= 1 + i * 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < Numb; i++)
                {
                    for (int j = 0; j < Numb - 1 - i; j++)
                    {

                    }
                }
            }
        }
    }
}
