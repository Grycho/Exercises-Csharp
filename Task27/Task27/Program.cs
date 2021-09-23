using System;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program loads the numbers until 0 is entered. 
             *The program returns the number of numbers greater than 15*/

            int num, sum=0;

            do
            {
                Console.Write("Input a number: ");
                num = int.Parse(Console.ReadLine());
                if (num > 15)
                {
                    sum++;
                }
            } while (num != 0); 
            Console.WriteLine("\nYou entered '0' program is end - Numbers greater than 15 was: {0}", sum);
        }
    }
}
