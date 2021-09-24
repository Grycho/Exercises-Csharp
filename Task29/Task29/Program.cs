using System;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of values in cells. Required auxiliary variable for calculating sum

            Console.WriteLine("Enter 10 numbers:");
            int[] tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var element in tab)
            {
                sum += element;
            }
            Console.WriteLine("\nSum of values: "+ sum);
        }
    }
}
