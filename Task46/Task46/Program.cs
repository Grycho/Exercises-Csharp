using System;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a NumberDigits function that returns the number of digits in an integer

            int NumberDigits(int x)
            {
                int Value = 0;
                while (x!= 0)
                {
                    Value++;
                    x /= 10;
                }
                return Value;
            }
        }
    }
}
