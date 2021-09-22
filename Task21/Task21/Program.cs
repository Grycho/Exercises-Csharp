using System;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that loads numbers for as long as the number is in the range -100 to 100. 
             * Calculates the sum the numbers loaded.*/

            int num;

            do
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered a number: {0}", num);
            } 
            while (num >= -100 && num <= 100);
            Console.WriteLine("\nYou entered a value out of range - you finished");
        }
    }
}
