using System;

namespace Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaying even numbers from the keyboard.

            Console.WriteLine("Enter 10 numbers:");
            int[] tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if(tab[i] % 2 == 0)
                {
                    Console.Write("\nEven number: {0}", tab[i]);
                }
            }
        }
    }
}
