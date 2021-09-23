using System;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program of testing whether the given number is Prime number. 
             *Minimize the number of operations dividing*/

            int x;
            Console.WriteLine("Input a number: ");
            x = int.Parse(Console.ReadLine());
            bool frst = true;

            for (int i = 2; i* i <= x ; i++)
            {
                if (x % i == 0) frst = false;
            }
        }
    }
}
