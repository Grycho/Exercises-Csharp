using System;

namespace Task47
{
    class Program
    {
        struct Coin
        {
            public int Coin1, Coin2, Coin5, Bankn10;
        }
        static void Main(string[] args)
        {
            /*Program that converts the amount of money (integer) specified by the user 
             * into the smallest possible amount of coins and banknotes with 
             * the denominations of 1, 2, 5, 10 PLN*/

            Coin Banknotes(int x)
            {
                Coin Value;
                Value.Bankn10 = x / 10; x %= 10;
                Value.Coin5 = x / 10; x %= 5;
                Value.Coin2 = x / 2; x %= 2;
                Value.Coin1 = x / 1;
                return Value;
            }

        }
    }
}
