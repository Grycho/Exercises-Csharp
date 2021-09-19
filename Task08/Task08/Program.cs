using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program that checks if a year is leap year

            int year;
            Console.WriteLine("Which year do you want to check: ");
            year = int.Parse(Console.ReadLine());

            if (year%400 == 0)
            {
                Console.WriteLine("\nThe year is LEAP");
            }
            else if (year%100 == 0)
            {
                Console.WriteLine("\nThe year is NOT a leap");
            }
            else if (year%4 == 0)
            {
                Console.WriteLine("\nThe year is LEAP");
            }
            else
            {
                Console.WriteLine("\nThe year is NOT a leap");
            }
            Console.WriteLine("\nEnd of program!");
        }
    }
}
