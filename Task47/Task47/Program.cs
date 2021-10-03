using System;

namespace Task47
{
    class Program
    {
        struct Coins
        {
            public int Coin1, Coin2, Coin5, Bankn10;
        }
        static void Main(string[] args)
        {
            /*Program that converts the amount of money (integer) specified by the user 
             * into the smallest possible amount of coins and banknotes with 
             * the denominations of 1, 2, 5, 10 PLN*/

            static Coins Banknotes(int x)
            {
                Coins Value;
                Value.Bankn10 = x / 10; x %= 10;
                Value.Coin5 = x / 5; x %= 5;
                Value.Coin2 = x / 2; x %= 2;
                Value.Coin1 = x / 1;
                return Value;
            }
            int Numb;
            Console.Write("Enter the amount: ");
            Numb = int.Parse(Console.ReadLine());
            Coins c = Banknotes(Numb);
            Console.WriteLine("\nAmount of coins: 1PLN = {0}, 2PLN = {1}, 5PLN = {2}, banknotes: 10PLN = {3}", c.Coin1, c.Coin2, c.Coin5, c.Bankn10);
        }
    }
}
