using System;

namespace Task51
{
    class Program
    {
        static bool Prime(int Numb)
        {
            //A function that checks whether the given number is prime

            Console.Write("Give me a number(we will check it is a prime number): ");
            Numb = int.Parse(Console.ReadLine());
            for (int i = 2; i * i <= Numb; i++)
            {
                if (Numb % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Prime(97));
        }
    }
}
