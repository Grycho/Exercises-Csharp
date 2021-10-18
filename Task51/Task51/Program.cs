using System;

namespace Task51
{
    class Program
    {
        static bool Prime(int n)
        {
            //A function that checks whether the given number is prime

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Prime(97));
        }
    }
}
