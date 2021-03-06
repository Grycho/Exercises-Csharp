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
            int[] even = new int[3000];
            int[] odd = new int[3000];

            for (int i = 0; i < 3000; i++)
            {
                Console.WriteLine("Randoms: {0}", even[i] = 2 * Numb.Next(-1000, 1000));
                Console.WriteLine("Randoms: {0}", odd[i] = 1 + 2 * Numb.Next(-1000, 1000));
            }
            int SumEven = 0;
            foreach (var Element in even)
            {
                if (Element % 2 == 0)
                {
                    SumEven += Element;
                }
            }
            Console.WriteLine("\nEven sum: " + SumEven);

            int SumOdd = 0;
            foreach (var Element in odd)
            {
                if (Element % 2 == 1 || Element < 0)
                {
                    SumOdd += Element;
                }
            }
            Console.WriteLine("\nOdd sum: " + SumOdd);
        }
    }
}
