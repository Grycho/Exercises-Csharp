using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program reads the number of the day and displays name in words. Use the switch statement.

            int days;
            Console.WriteLine("Which day of the week: ");
            days = int.Parse(Console.ReadLine());

            switch (days)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Wrong value given!"); break;
            }
        }
    }
}
