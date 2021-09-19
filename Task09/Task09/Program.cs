using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the loaded number is integer has the penultimate 
             * digit greater than 4 and displays appropriate messages, if it is and it is not.*/

            int a;
            Console.Write("Give me a number: ");
            a = int.Parse(Console.ReadLine());

            if (a % 100 > 49)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
