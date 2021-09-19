using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program that checks if a year is leap year

            int year;
            bool correct;
            Console.Write("Which year do you want to check: ");
            correct = int.TryParse(Console.ReadLine(), out year);       //Protection against typed letters

            /*Checking the year is divisible by 400. 
            * If yes, a message is displayed and goes to the line 
            * End of program other condition are not checked*/
            if (correct == true)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("The year is LEAP");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("The year is NOT a leap");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("The year is LEAP");
                }
                else
                {
                    Console.WriteLine("The year is NOT a leap");
                }
                Console.WriteLine("End of program!");
            }
            else
            {
                Console.WriteLine("An invalid value was entered!");
            }
        }
    }
}
