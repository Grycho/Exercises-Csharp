using System;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program that draws a "Christmas tree" composed of asterisks (*) in the console.

            int num;
            Console.WriteLine("How high should be the christmas tree?");
            Console.Write("Input how many lines: ");
            num = int.Parse(Console.ReadLine());

            int manySpaces = num - 1, manyStars = 1;
            for (int line = 1; line <= num; line++)
            {
                for (int space = 0; space < manySpaces; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < manyStars; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                manySpaces -= 1;
                manyStars += 2;
            }
        }
    }
}
