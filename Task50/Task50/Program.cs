using System;

namespace Task50
{
    class Program
    {
        static void Average(int[] tab, int HowMany)
        {
            /*A program that asks the user to enter the length of a string of numbers, 
             * and then reads those numbers into the array one by one. Then the program 
             * transfers the data of the function, which is to calculate the average of 
             * the given numbers and write it to the screen as follows: 
             * The average of the numbers 1 2 3 4 5 6 is 3.5 */
            //Program must be protected against division by 0 and entering incorrect values

            double Sum = 0, average;
            foreach (var Element in tab)
            {
                Sum += Element;
            }
            average = Sum / HowMany;
            Console.Write("Average of the numbers: ");
            foreach (var item in collection)
            {

            }
        }

        static void Main(string[] args)
        {

        }
    }
}
