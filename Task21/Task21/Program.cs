using System;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that loads numbers for as long as the number is in 
             * the range -100 to 100. Calculates total numbers loaded.*/

            int num, sum=0;

            do
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num >= -100 && num <= 100);
            Console.WriteLine("\nYou entered a value out of range - Total number is: {0}", sum);
        }
    }
}
