using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program that allows you to calculate the amount of the monthly installment 
             * for the purchased equipment. The input data for the program are: 
             * the price of the goods (from 100$ to 10,000$) and the number of installments (from 6 to 48).*/

            int installment;
            double priceGoods;
            Console.Write("The price of the goods(from 100$ to 10,000$): ");
            priceGoods = double.Parse(Console.ReadLine());
            Console.Write("How many installments do you want to take out a credit for(from 6 to 48): ");
            installment = int.Parse(Console.ReadLine());
        }
    }
}
