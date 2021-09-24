using System;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of values in cells. Required auxiliary variable for calculating sum

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
            Console.WriteLine("Sum of values: "+ sum);
        }
    }
}
