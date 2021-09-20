using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* [Percentage calculation] A program that allows you to calculate the amount of the monthly installment 
             * for the purchased equipment. The input data for the program are: 
             * the price of the goods (from 100$ to 10,000$) and the number of installments (from 6 to 48).*/

            int installment;
            double priceGoods;
            Console.Write("The price of the goods(from 100$ to 10,000$): ");
            priceGoods = double.Parse(Console.ReadLine());
            Console.Write("\nHow many installments(from 6 to 48) do you want to take out a credit for: ");
            installment = int.Parse(Console.ReadLine());

            double monthlyInstall, percent, calcPercent;
            if (installment >= 6 && installment <= 12)
            {
                percent = 2.5;
                calcPercent = (1 + percent / 100);                          //Percentage calculation = 2,5%
                monthlyInstall = (priceGoods * calcPercent) / installment;
                Console.WriteLine("\nThe monthly installment is = {0}$", Math.Round(monthlyInstall, 2));
            }
            else if (installment >= 13 && installment <= 24)
            {
                percent = 5;
                calcPercent = (1 + percent / 100);                          //Percentage calculation = 5%
                monthlyInstall = (priceGoods * calcPercent) / installment;
                Console.WriteLine("\nThe monthly installment is = {0}$", Math.Round(monthlyInstall, 2));
            }
            else if (installment >= 25 && installment <= 48)
            {
                percent = 10;
                calcPercent = (1 + percent / 100);                          //Percentage calculation = 10%
                monthlyInstall = (priceGoods * calcPercent) / installment;
                Console.WriteLine("\nThe monthly installment is = {0}$", Math.Round(monthlyInstall, 2));
            }
            else
            {
                Console.WriteLine("\nIncorrect data!");
            }
        }
    }
}
