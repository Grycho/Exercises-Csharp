using System;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program for calculating total of the digits 
             *of the decimal expansion for a given natural number.*/

            int num;
            Console.Write("Input a number: ");
            num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("Total is: " + sum);
        }
    }
}
