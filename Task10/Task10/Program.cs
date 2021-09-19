using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that calculates the salary of a seller of a certain product.
             * If in a given settlement period the seller has sold more than 50 items of the product,
             * he receives 30$ for each item sold, and if he sold less, he receives 20$ for each item.
             * The input data to the program should be the number of items sold in a given settlement period.*/

            int pieces;
            Console.Write("How many pieces have you sold: ");
            pieces = int.Parse(Console.ReadLine());

            int payment;
            if (pieces > 50)
            {
                payment = pieces * 30;
                Console.WriteLine("Payment is: " + payment);
            }
            else
            {
                payment = pieces * 20;
                Console.WriteLine("Payment is: " + payment);
            }
        }
    }
}
