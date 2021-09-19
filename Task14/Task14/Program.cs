using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Program which a given numerical month will indicate how many days have elapsed
             * from the beginning of the year to the 1st day of the given month*/

            int month;
            Console.Write("Enter the month(number) and we will se how many days elapsed: ");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: Console.WriteLine("Until the 1st day of January has elapsed: {0} days", 0); break;
                case 2: Console.WriteLine("Until the 1st day of February has elapsed: {0} days", 31); break;
                case 3: Console.WriteLine("Until the 1st day of March has elapsed: {0} days", 59); break;
                case 4: Console.WriteLine("Until the 1st day of April has elapsed: {0} days", 90); break;
                case 5: Console.WriteLine("Until the 1st day of May has elapsed: {0} days", 120); break;
                case 6: Console.WriteLine("Until the 1st day of June has elapsed: {0} days", 151); break;
                case 7: Console.WriteLine("Until the 1st day of July has elapsed: {0} days", 181); break;
                case 8: Console.WriteLine("Until the 1st day of August has elapsed: {0} days", 212); break;
                case 9: Console.WriteLine("Until the 1st day of September has elapsed: {0} days", 243); break;
                case 10: Console.WriteLine("Until the 1st day of October has elapsed: {0} days", 273); break;
                case 11: Console.WriteLine("Until the 1st day of November has elapsed: {0} days", 304); break;
                case 12: Console.WriteLine("Until the 1st day of December has elapsed: {0} days", 334); break;
                default: Console.WriteLine("Incorrect data was entered!"); break;
            }
        }
    }
}
