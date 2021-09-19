using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The cost of printing one copy of the book is 10$ for a circulation of more than 1000, 
             * 12$ for a circulation of 500 to 1000 and 15$ for a circulation of less than 500. 
             * For the entered value - the number of books to be printed, it is to provide 
             * the cost of printing the entire run.*/

            int book;
            Console.Write("How many books you want to print: ");
            book = int.Parse(Console.ReadLine());

            int cost;
            if (book > 1000)
            {
                cost = book * 10;
                Console.WriteLine("Total printing cost: " + cost);
            }
            else if (book > 500 && book <= 1000)
            {
                cost = book * 12;
                Console.WriteLine("Total printing cost: " + cost);
            }
            else if (book <= 500 && book >= 0)
            {
                cost = book * 15;
                Console.WriteLine("Total printing cost: " + cost);
            }
            else
            {
                Console.WriteLine("You entered the wrong value!");
            }
        }
    }
}
