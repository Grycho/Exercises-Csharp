using System;

namespace Task51
{
    class Program
    {
        static bool Prime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //A function that checks whether the given number is prime


        }
    }
}
